using System.Collections.Generic;

namespace Support.CallCenter.Pbx.Services.Interfaces
{
    public interface IPbxMessagesParser
    {
        /// <summary>
        /// Вытаскивает массив сообщений из полученного дампа астериска.
        /// </summary>
        /// <param name="inputMessage"></param>
        /// <returns></returns>
        List<string> ExtractPbxMessages(string inputMessage);

        /// <summary>
        /// Конвертирует сообщение от астериска в JSON-объект
        /// </summary>
        /// <param name="inputMessage"></param>
        /// <returns></returns>
        Dictionary<string, string> ParseMessage(string inputMessage);
    }
}