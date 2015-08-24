using System;

namespace Support.CallCenter.Pbx.EventArguments
{
    public class PbxRawMessageEventArgs : EventArgs
    {
        public string Message { get; set; }
    }
}