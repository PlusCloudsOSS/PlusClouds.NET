using System;
using PlusCloudsNet.Attributes;

namespace PlusCloudsNet.Request.Products
{
    public class PurchaseProductRequest : AccessTokenizedRequest, IUserSessionRequest
    {
        [Name("products")]
        public long ProductId { get; set; }

        public long ForService { get; set; }
        public string PaymentMethod { get; set; }
        public long CardId { get; set; }
        public string CcName { get; set; }
        public string CcSurnane { get; set; }
        public string CcType { get; set; }
        public string CcNumber { get; set; }
        public string CcMonth { get; set; }
        public string CcYear { get; set; }
        public bool CcSave { get; set; }
        public string BrmData { get; set; }

        [Name("sid")]
        public string SessionId { get; set; }
    }
}