using System;
using System.Collections.Generic;

namespace Support.CallCenter.Pbx.EventArguments
{
    public class PbxMessagesEventArgs: EventArgs
    {
        public List<Dictionary<string,string>> Messages { get; set; }
    }
}