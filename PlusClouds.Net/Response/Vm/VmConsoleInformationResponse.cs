using System.Collections.Generic;

namespace PlusClouds.Net.Response.Vm
{
    public class VmConsoleInformationResponse : BaseResponse
    {
        public string Url { get; set; }
        public Dictionary<string, string> Host { get; set; }
        public int Port { get; set; }
    }
}