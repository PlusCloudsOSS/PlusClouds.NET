namespace PlusClouds.Net.Response.Vm
{
    public class VmDeleteResponse : BaseResponse
    {
        public Job Job { get; set; }
        public VirtualMachineDeleteResponse Vm { get; set; }
    }

    public class Job
    {
        public string Id { get; set; }
        public string Status { get; set; }
    }

    public class VirtualMachineDeleteResponse
    {
        public int Id { get; set; }
        public int ServiceId { get; set; }
        public string Status { get; set; }
    }
}