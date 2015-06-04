using System;

namespace PlusCloudsNet.Response.Vm
{
    public class VmJobResponse : BaseResponse
    {
        public Job Job { get; set; }
        public VmStatus Vm { get; set; }
    }

    public class Job
    {
        public string Id { get; set; }
        public string Status { get; set; }
    }

    public class VmStatus
    {
        public Int64 Id { get; set; }
        public Int64 ServiceId { get; set; }
        public string Status { get; set; }
    }
}