namespace PlusCloudsNet.Request.Vm
{
    public class VmAddIpRequest : VmJobRequest
    {
        public int ForService { get; set; }
        public dynamic BrmData { get; set; }
    }
}