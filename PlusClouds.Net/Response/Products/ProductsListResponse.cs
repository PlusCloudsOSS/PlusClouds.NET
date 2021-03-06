using System.Collections.Generic;

namespace PlusCloudsNet.Response.Products
{
    public class ProductsListResponse : BaseResponse
    {
        public string Current_Locale { get; set; }
        public Dictionary<string, Product> Products { get; set; }
        public int RowCount { get; set; }
        public Pager Pager { get; set; }
    }

    public class PriceCurrency
    {
        public double Value { get; set; }
        public string Formated { get; set; }
        public string Currency { get; set; }
        public ExchangeRate ExchangeRate { get; set; }
    }

    public class ExchangeRate
    {
        public double Value { get; set; }
        public string Formated { get; set; }
    }

    public class Price
    {
        public PriceCurrency Default { get; set; }
        public PriceCurrency Converted { get; set; }
        public List<string> Properties { get; set; }
    }

    public class Company
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Tax_Office { get; set; }
        public string Tax_Number { get; set; }
    }

    public class Vendor
    {
        public long Id { get; set; }
        public bool Sys_User { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Avatar { get; set; }
        public Company Company { get; set; }
    }

    public class Template
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Distribution { get; set; }
        public int Cpu { get; set; }
        public int Ram { get; set; }
        public int Hdd { get; set; }
        public string In_Maintenance { get; set; }
    }

    public class Datacenter
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Dictionary<string, PriceCurrency> Cpu_Price { get; set; }
        public Dictionary<string, PriceCurrency> Ram_Price { get; set; }
        public Dictionary<string, PriceCurrency> Hdd_Price { get; set; }
        public Dictionary<string, PriceCurrency> Bw_Price { get; set; }
    }

    public class Product
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
        public Price Price { get; set; }
        public string Discount { get; set; }
        public string Installments { get; set; }
        public string Version { get; set; }
        public string Os { get; set; }
        public string Cpu { get; set; }
        public string Ram { get; set; }
        public string Hdd { get; set; }
        public string Bw { get; set; }
        public string Trial_Time { get; set; }
        public string Is_Resource { get; set; }
        public string ResourcesType { get; set; }
        public string Resources_Type { get; set; }
        public string Rating_Total { get; set; }
        public string Rating_Count { get; set; }
        public string Payment_Type { get; set; }
        public string Product_Type { get; set; }
        public dynamic Options { get; set; }
        public dynamic Brm_Fields { get; set; }
        public Vendor Vendor { get; set; }
        public Template Template { get; set; }
        public string Description { get; set; }
        public string Details { get; set; }
        public string Support_Description { get; set; }
        public string Support_Details { get; set; }
        public string Highlights { get; set; }
        public string Refund_Policy { get; set; }
        public string Eula { get; set; }
        public string Video { get; set; }
        public Datacenter Datacenter { get; set; }
        public Dictionary<string, string> Images { get; set; }
        public bool Is_Application_Server { get; set; }
    }

    public class Pager
    {
        public int PageCount { get; set; }
        public int ItemCountPerPage { get; set; }
        public int First { get; set; }
        public int Current { get; set; }
        public int Last { get; set; }
        public int Next { get; set; }
        public Dictionary<string, int> PagesInRange { get; set; }
        public int FirstPageInRange { get; set; }
        public int LastPageInRange { get; set; }
    }
}