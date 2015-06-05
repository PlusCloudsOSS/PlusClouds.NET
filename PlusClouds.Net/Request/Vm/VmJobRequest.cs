using PlusCloudsNet.Attributes;

namespace PlusCloudsNet.Request.Vm
{
    public class VmJobRequest : AccessTokenizedRequest, IUserSessionRequest
    {
        public long ServiceId { get; set; }

        [Name("sid")]
        public string SessionId { get; set; }
    }
}