using System;

namespace PlusCloudsNet.Request.Vm
{
    public class VmAddIpRequest : VmJobRequest
    {
        public Int64 ForService { get; set; }
        public dynamic BrmData { get; set; }
    }
}