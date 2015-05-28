using System.Collections.Generic;

namespace PlusClouds.Net.Response.Products
{
    public class ProductsListResponse : BaseResponse
    {
        public string CurrentLocale { get; set; }
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
        public string Id { get; set; }
        public string Name { get; set; }
        public string TaxOffice { get; set; }
        public string TaxNumber { get; set; }
    }

    public class Vendor
    {
        public int Id { get; set; }
        public bool SysUser { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Avatar { get; set; }
        public Company Company { get; set; }
    }

    public class Template
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Distribution { get; set; }
        public int Cpu { get; set; }
        public int Ram { get; set; }
        public int Hdd { get; set; }
        public string InMaintenance { get; set; }
    }

    public class PartPrice
    {
        public PriceCurrency Default { get; set; }
    }

    public class Datacenter
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public PartPrice CpuPrice { get; set; }
        public PartPrice RamPrice { get; set; }
        public PartPrice HddPrice { get; set; }
        public PartPrice BwPrice { get; set; }
    }

    public class Product
    {
        public string Id { get; set; }
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
        public string TrialTime { get; set; }
        public string IsResource { get; set; }
        //Object Type
        public object ResourcesType { get; set; }
        public string RatingTotal { get; set; }
        public string RatingCount { get; set; }
        public string PaymentType { get; set; }
        public string ProductType { get; set; }
        //Object Type
        public object Options { get; set; }
        //Object Type
        public object BrmFields { get; set; }
        public Vendor Vendor { get; set; }
        public Template Template { get; set; }
        public string Description { get; set; }
        public string Details { get; set; }
        public string SupportDescription { get; set; }
        public string SupportDetails { get; set; }
        public string Highlights { get; set; }
        public string RefundPolicy { get; set; }
        public string Eula { get; set; }
        public string Video { get; set; }
        public Datacenter Datacenter { get; set; }
        public Dictionary<string, string> Images { get; set; }
        public bool IsApplicationServer { get; set; }
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