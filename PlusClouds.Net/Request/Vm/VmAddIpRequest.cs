using PlusClouds.Net.Resources;

namespace PlusClouds.Net.Request.Vm
{
    public class VmAddIpRequest : VmJobRequest
    {
        public int ForService { get; set; }
        public dynamic BrmData { get; set; }
    }
}