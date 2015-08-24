using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using Support.CallCenter.Pbx.Services.Interfaces;

namespace Support.CallCenter.Pbx.Services.Implementations
{
    public class AsteriskMessagesParser : IPbxMessagesParser
    {
        //��� ������������ ������� � �����.
        private readonly Regex mNonAlphabeticRegex = new Regex(@"[^\p{L}\p{N}\.]+");

        /// <summary>
        /// ����������� ������ ��������� �� ����������� ����� ���������.
        /// </summary>
        /// <param name="inputMessage"></param>
        /// <returns></returns>
        public List<string> ExtractPbxMessages(string inputMessage)
        {
            return inputMessage.Split(new[]{"\r\n\r\n"}, StringSplitOptions.RemoveEmptyEntries).ToList();
        }

        /// <summary>
        /// ������������ ��������� �� ��������� � JSON-������
        /// </summary>
        /// <param name="inputMessage"></param>
        /// <returns></returns>
        public Dictionary<string, string> ParseMessage(string inputMessage)
        {
            inputMessage = inputMessage.Trim(new char[' ']);
            var messageRows = inputMessage.Split(new[] { "\r\n" }, StringSplitOptions.None);


            var result = new Dictionary<string, string>();
            
            foreach (var messageRow in messageRows)
            {
                var splitedRow = messageRow.Split(new[] { ":" }, StringSplitOptions.None);

                //������ ��������� ������ ����� ������ "����: ��������", ������� ����� �������� ����� ����� ��� �������� � �������.
                if (splitedRow.Count() < 2)
                {
                    continue;
                }
                var rowKey = mNonAlphabeticRegex.Replace(splitedRow[0], "");
                var rowValue = mNonAlphabeticRegex.Replace(splitedRow[1], "");
                if (!result.ContainsKey(rowKey))
                {
                    result.Add(rowKey,rowValue);
                }
                
            }

            return result;
        }
    }
}