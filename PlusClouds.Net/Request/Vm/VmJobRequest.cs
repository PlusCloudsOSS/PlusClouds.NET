using System;
using PlusCloudsNet.Attributes;

namespace PlusCloudsNet.Request.Vm
{
    public class VmJobRequest : AccessTokenizedRequest
    {
        [Name("sid")]
        public string SessionId { get; set; }

        public Int64 ServiceId { get; set; }
    }
}