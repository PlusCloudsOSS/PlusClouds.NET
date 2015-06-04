namespace PlusCloudsNet.Request
{
    public interface IPaginationRequest
    {
        int Page { get; set; }
        int Limit { get; set; }
    }
}