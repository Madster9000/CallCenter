using System.Collections.Generic;

namespace Support.CallCenter.Pbx.Services.Interfaces
{
    public interface IPbxMessagesParser
    {
        /// <summary>
        /// ����������� ������ ��������� �� ����������� ����� ���������.
        /// </summary>
        /// <param name="inputMessage"></param>
        /// <returns></returns>
        List<string> ExtractPbxMessages(string inputMessage);

        /// <summary>
        /// ������������ ��������� �� ��������� � JSON-������
        /// </summary>
        /// <param name="inputMessage"></param>
        /// <returns></returns>
        Dictionary<string, string> ParseMessage(string inputMessage);
    }
}