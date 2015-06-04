namespace PlusCloudsNet.Response
{
    public abstract class BaseResponse
    {
        public bool Result { get; set; }
        public int ErrorCode { get; set; }
        public string ErrorMessage { get; set; }
    }
}