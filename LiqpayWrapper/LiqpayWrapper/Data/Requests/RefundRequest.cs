using Newtonsoft.Json;

namespace LiqpayWrapper.Data.Requests
{
    public class RefundRequest : BaseRequest
    {
        [JsonProperty("order_id")]
        public string OrderId { get; set; }

        [JsonProperty("amount")]
        public decimal Amount { get; set; }
    }
}
