using System;

namespace PlusCloudsNet.Request.Vm
{
    public class VmAddIpRequest : VmJobRequest
    {
        public long ForService { get; set; }
        public dynamic BrmData { get; set; }
    }
}