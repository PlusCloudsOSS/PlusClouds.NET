using System;

namespace PlusClouds.Net.Response.Products
{
    public class PurchaseProductResponse : BaseResponse
    {
        public string Ref { get; set; }
        public DateTime Date { get; set; }
        public string DateGmt { get; set; }
    }
}