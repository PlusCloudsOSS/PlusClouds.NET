using PlusClouds.Net.Resources;

namespace PlusClouds.Net.Request.Vm
{
    public class VmChangePasswordRequest : VmJobRequest
    {
        public string OldPassword { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }
}