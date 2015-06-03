using PlusClouds.Net.Resources;

namespace PlusClouds.Net.Request.Vm
{
    public class VmStopRequest : VmJobRequest
    {
        public bool ForceStop { get; set; }
    }
}