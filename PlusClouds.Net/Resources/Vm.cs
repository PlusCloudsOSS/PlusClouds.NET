using PlusClouds.Net.Request.Vm;
using PlusClouds.Net.Response.Vm;
using RestSharp;

namespace PlusClouds.Net.Resources
{
    public class Vm : BaseResource
    {
        private const string vmDelete = "vm/delete";
        private const string list = "vm";

        public Vm(PlusClouds plusClouds)
            : base(plusClouds)
        {
        }

        public VmListResponse List(VmListRequest vmListRequest)
        {
            return PlusClouds.Execute<VmListResponse>(list, Method.GET, vmListRequest);
        }

        public VmDeleteResponse Delete(VmDeleteRequest vmDeleteRequest)
        {
            return PlusClouds.Execute<VmDeleteResponse>(vmDelete, Method.GET, vmDeleteRequest);
        }
    }
}