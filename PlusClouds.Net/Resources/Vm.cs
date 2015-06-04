using PlusCloudsNet.Request.Vm;
using PlusCloudsNet.Response.Vm;
using RestSharp;

namespace PlusCloudsNet.Resources
{
    public class Vm : BaseResource
    {
        private const string list = "vm";
        private const string vmDelete = "vm/delete";
        private const string vmStart = "vm/start";
        private const string vmStop = "vm/stop";
        private const string vmReboot = "vm/reboot";
        private const string vmChangePassword = "vm/change-password";
        private const string vmChangeServerName = "vm/change-server-name";
        private const string vmAddIp = "vm/add-ip";
        private const string vmGetConsole = "vm/get-console";

        public Vm(PlusClouds plusClouds)
            : base(plusClouds)
        {
        }

        public VmListResponse List(VmListRequest vmListRequest)
        {
            return PlusClouds.Execute<VmListResponse>(list, Method.GET, vmListRequest);
        }

        public VmJobResponse Delete(VmDeleteRequest vmDeleteRequest)
        {
            return PlusClouds.Execute<VmJobResponse>(vmDelete, Method.GET, vmDeleteRequest);
        }

        public VmJobResponse Start(VmJobRequest vmJobRequest)
        {
            return PlusClouds.Execute<VmJobResponse>(vmStart, Method.GET, vmJobRequest);
        }

        public VmJobResponse Stop(VmStopRequest vmStartRequest)
        {
            return PlusClouds.Execute<VmJobResponse>(vmStop, Method.GET, vmStartRequest);
        }

        public VmJobResponse Reboot(VmRebootRequest vmRebootRequest)
        {
            return PlusClouds.Execute<VmJobResponse>(vmReboot, Method.GET, vmRebootRequest);
        }

        public VmJobResponse ChangePassword(VmChangePasswordRequest vmChangePasswordRequest)
        {
            return PlusClouds.Execute<VmJobResponse>(vmChangePassword, Method.GET, vmChangePasswordRequest);
        }

        public VmJobResponse ChangeServerName(VmChangeServerNameRequest vmChangeServerNameRequest)
        {
            return PlusClouds.Execute<VmJobResponse>(vmChangeServerName, Method.GET, vmChangeServerNameRequest);
        }

        public VmJobResponse AddIp(VmAddIpRequest vmAddIpRequest)
        {
            return PlusClouds.Execute<VmJobResponse>(vmAddIp, Method.GET, vmAddIpRequest);
        }

        public VmConsoleInformationResponse GetConsole(VmJobRequest vmJobRequest)
        {
            return PlusClouds.Execute<VmConsoleInformationResponse>(vmGetConsole, Method.GET, vmJobRequest);
        }
    }
}