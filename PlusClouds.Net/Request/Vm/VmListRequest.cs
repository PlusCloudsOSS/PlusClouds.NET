using PlusCloudsNet.Attributes;

namespace PlusCloudsNet.Request.Vm
{
    public class VmListRequest : AccessTokenizedRequest, IPaginationRequest
    {
        [Name("sid")]
        public string SessionId { get; set; }

        public int Id { get; set; }
        public int GroupId { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }

        [Name("q")]
        public string SearchQuery { get; set; }

        public string OrderBy { get; set; }
        public int Page { get; set; }
        public int Limit { get; set; }
    }
}