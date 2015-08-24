using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using Support.CallCenter.Pbx.Adapters.Implementations;
using Support.CallCenter.Pbx.Adapters.Interfaces;
using Support.CallCenter.Pbx.EventArguments;
using Support.CallCenter.Pbx.Factories;
using Support.CallCenter.Pbx.Listeners.Interfaces;
using Support.CallCenter.Pbx.Services.Interfaces;

namespace Support.CallCenter.Pbx.Listeners.Implementations
{
    public class AsteriskListener : IPbxListener
    {
        private readonly List<string> mValueableEvents = new List<string> { "Newchannel", "Join", "Bridge", "Hangup", "Dial", "NewCallerid" };

        private readonly IPbxConfigurationService mPbxConfigurationService;
        private readonly IPbxMessagesParser mPbxMessagesParser;
        private readonly ISocketAdapterFactory mSocketAdapterFactory;

        private const int cSocketReadBufer = 1024;
        private string mAsteriskMessageTail = "";

        public AsteriskListener(IPbxConfigurationService pbxConfigurationService, IPbxMessagesParser pbxMessagesParser, ISocketAdapterFactory socketAdapterFactory)
        {
            mPbxConfigurationService = pbxConfigurationService;
            mPbxMessagesParser = pbxMessagesParser;
            mSocketAdapterFactory = socketAdapterFactory;
        }

        public void Listen()
        {
            try
            {
                //вытаскиваем параметры подключения к астериску
                var asteriskConfiguration = mPbxConfigurationService.GetPbxConfiguration();
                var loginCommand = mPbxConfigurationService.GetLoginCommand(asteriskConfiguration);

                using (ISocketAdapter socket = mSocketAdapterFactory.CreateSocketAdapter())
                {
                    //Создаём сокет для подключения к астериску и подключаемся к нему
                    socket.Connect(asteriskConfiguration.IpAddress, asteriskConfiguration.Port);

                    //авторизуемся
                    socket.Send(Encoding.ASCII.GetBytes(loginCommand));

                    //читаем cSocketReadBufer байт из сокета
                    var bytesRead = 1;

                    while (bytesRead != 0)
                    {
                        var asteriskAnswer = new byte[cSocketReadBufer];
                        bytesRead = socket.Receive(asteriskAnswer);

                        OnFullMessageRecived(new PbxRawMessageEventArgs { Message = Encoding.ASCII.GetString(asteriskAnswer, 0, asteriskAnswer.Length) });
                        //Полученный массив байт преобразуем к строке
                        var asteriskMessage = ParseFullAsteriskMessage(asteriskAnswer);

                        var messages = mPbxMessagesParser.ExtractPbxMessages(asteriskMessage);
                        var parsedMessages =
                            messages
                                .Select
                                (
                                    t => mPbxMessagesParser.ParseMessage(t)
                                )
                                .Where
                                (
                                    r =>
                                        r.ContainsKey("Event")
                                        &&
                                        mValueableEvents.Contains(r["Event"])
                                )
                                .ToList();

                        //Если нашли события, запускаем событие полученного сообщения
                        if (parsedMessages.Any())
                        {
                            OnPbxMessageRecived(new PbxMessagesEventArgs { Messages = parsedMessages });
                        }

                        //Читаем следующее сообщение
                        //asteriskAnswer = socket.Receive(cSocketReadBufer);
                    }
                }
                
                
            }
            catch (Exception ex)
            {
                var errorMessage = String.Format("Подключение к астериску отвалилось с ошибкой. \r\n {0}", ex);
                OnPbxConnectionLost(new PbxErrorEventArgs{ErrorMessage = errorMessage});
            }


            OnPbxConnectionLost(new PbxErrorEventArgs { ErrorMessage = "Подключение к астериску отвалилось"});
        }

        /// <summary>
        /// Для корректной обработки потока байт от астериска, необходимо:
        /// 1. Обноруживать незаконченные сообщение в прочитанном буфере.
        /// 2. Сохранять "хвост".
        /// 3. Склеивать хвост и новое сообщение.
        /// </summary>
        /// <param name="asteriskAnswer">"грязное" сообщение от астериска - может содержать не полное сообщение в хвосте.</param>
        /// <returns>Чистое сообщение, без хвостов</returns>
        private string ParseFullAsteriskMessage(byte[] asteriskAnswer)
        {
            var rawAsteriskMessage = Encoding.ASCII.GetString(asteriskAnswer, 0, asteriskAnswer.Length);

            //Склеиваем текущее сообщение с предыдущим
            var currentMessage = mAsteriskMessageTail + rawAsteriskMessage;

            //Ищем последнее вхождение разделителя сообщений.
            var endOfMessageIndex = currentMessage.LastIndexOf("\r\n\r\n");
            if (endOfMessageIndex < 0)
            {
                return "";
            }

            //сохраняем хвост.
            mAsteriskMessageTail = currentMessage.Substring(endOfMessageIndex + 4);

            //возвращаем сообщение без хвоста.
            return currentMessage.Substring(0, endOfMessageIndex + 4); ;
        }

        #region Events
        public event EventHandler<PbxRawMessageEventArgs> FullMessageRecived;

        public event EventHandler<PbxMessagesEventArgs> PbxMessageRecived;
        public event EventHandler<PbxErrorEventArgs> PbxConnectionLost;

        private void OnPbxMessageRecived(PbxMessagesEventArgs e)
        {
            var handler = PbxMessageRecived;
            if (handler != null) handler(this, e);
        }

        private void OnFullMessageRecived(PbxRawMessageEventArgs e)
        {
            var handler = FullMessageRecived;
            if (handler != null) handler(this, e);
        }

        private void OnPbxConnectionLost(PbxErrorEventArgs e)
        {
            var handler = PbxConnectionLost;
            if (handler != null) handler(this, e);
        }
        #endregion

        
    }
}