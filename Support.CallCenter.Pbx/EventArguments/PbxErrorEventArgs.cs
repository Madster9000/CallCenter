using System;

namespace Support.CallCenter.Pbx.EventArguments
{
    public class PbxErrorEventArgs : EventArgs
    {
        public string ErrorMessage { get; set; }
    }
}