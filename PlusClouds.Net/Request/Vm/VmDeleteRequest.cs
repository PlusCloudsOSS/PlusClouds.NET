using PlusCloudsNet.Attributes;

namespace PlusCloudsNet.Request.Vm
{
    public class VmDeleteRequest : AccessTokenizedRequest, IUserSessionRequest
    {
        public long ServiceId { get; set; }
        public bool ForceStop { get; set; }

        [Name("sid")]
        public string SessionId { get; set; }
    }
}