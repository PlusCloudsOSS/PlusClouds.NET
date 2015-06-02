using System.Collections.Generic;
using PlusClouds.Net.Response;
using PlusClouds.Net.Response.Products;

namespace PlusClouds.Net.Resources
{
    public class VmListResponse : BaseResponse
    {
        public string Current_Locale { get; set; }
        public Dictionary<string, Servers> Servers { get; set; }
        public int RowCount { get; set; }
        public Pager Pager { get; set; }
    }

    public class Servers
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Hostname { get; set; }
        public string Status { get; set; }
        public object Last_Status { get; set; }
        public string Cpu { get; set; }
        public string Ram { get; set; }
        public string Hdd { get; set; }
        public string Username { get; set; }
        public object Note { get; set; }
        public string Create_Time { get; set; }
        public string Domain { get; set; }
        public object Features { get; set; }
        public bool Pv { get; set; }
        public Dictionary<string, ServerProduct> Products { get; set; }
        public object Virtual_Machine_Groups_Id { get; set; }
        public object Monitoring_Id { get; set; }
        public string Dns_Record_Id { get; set; }
        public Template Template { get; set; }
        public Datacenter Datacenter { get; set; }
        public Dictionary<string, List<Ip>> Ip_List { get; set; }
        public Dictionary<string, Nat> Nat { get; set; }
        public Dictionary<string, Proxy> Proxies { get; set; }
    }

    public class ServerProduct
    {
        public string Services_Id { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        public bool Is_Prime { get; set; }
        public bool Is_Trial { get; set; }
        public bool Is_Expired { get; set; }
    }

    public class Ip
    {
        public string Ip_Addr { get; set; }
        public string Mac_Addr { get; set; }
        public bool Is_Primary { get; set; }
    }

    public class Proxy
    {
        public string Domain { get; set; }
        public bool Is_Active { get; set; }
    }

    public class Nat
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Source_Port { get; set; }
        public string Source_Ip { get; set; }
        public bool Is_Active { get; set; }
    }
}