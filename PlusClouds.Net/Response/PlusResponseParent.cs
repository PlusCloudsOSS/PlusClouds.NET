namespace PlusCloudsNet.Response
{
    public class PlusResponseParent : PlusResponseParent<BaseResponse>
    {
    }

    public class PlusResponseParent<T>
    {
        public T Response { get; set; }
    }
}