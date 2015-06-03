using PlusClouds.Net.Request.Vm;
using PlusClouds.Net.Response;
using PlusClouds.Net.Response.Vm;
using RestSharp;

namespace PlusClouds.Net.Resources
{
    public class Vm : BaseResource
    {
        private const string list = "vm";
        private const string vmDelete = "vm/delete";
        private const string vmStart = "vm/start";

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

        public VmJobResponse Delete(VmStartRequest vmStartRequest)
        {
            return PlusClouds.Execute<VmJobResponse>(vmStart, Method.GET, vmStartRequest);
        }
    }
}