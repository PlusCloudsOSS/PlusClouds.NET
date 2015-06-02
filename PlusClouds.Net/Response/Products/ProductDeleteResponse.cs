namespace PlusClouds.Net.Response.Products
{
    public class ProductDeleteResponse : BaseResponse
    {
        public Job Job { get; set; }
    }

    public class Job
    {
        public string Id { get; set; }
        public string Status { get; set; }
    }

    public class Vm
    {
        public int Id { get; set; }
        public int ServiceId { get; set; }
        public string Status { get; set; }
    }
}