using PlusClouds.Net.Attributes;
using PlusClouds.Net.Request;

namespace PlusClouds.Net.Resources
{
    public class VmJobRequest : AccessTokenizedRequest
    {
        [Name("sid")]
        public string SessionId { get; set; }

        public int ServiceId { get; set; }
    }
}