using PlusClouds.Net.Attributes;

namespace PlusClouds.Net.Request.Products
{
    public class PurchaseProductRequest : AccessTokenizedRequest
    {
        [Name("sid")]
        public string SessionId { get; set; }

        [Name("products")]
        public int ProductId { get; set; }

        public int ForService { get; set; }
        public string PaymentMethod { get; set; }
        public int CardId { get; set; }
        public string CcName { get; set; }
        public string CcSurnane { get; set; }
        public string CcType { get; set; }
        public string CcNumber { get; set; }
        public string CcMonth { get; set; }
        public string CcYear { get; set; }
        public bool CcSave { get; set; }
        public string BrmData { get; set; }
    }
}