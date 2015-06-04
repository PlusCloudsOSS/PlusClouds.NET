using System;
using PlusCloudsNet.Attributes;

namespace PlusCloudsNet.Request.Vm
{
    public class VmDeleteRequest : AccessTokenizedRequest
    {
        [Name("sid")]
        public string SessionId { get; set; }

        public Int64 ServiceId { get; set; }
        public bool ForceStop { get; set; }
    }
}