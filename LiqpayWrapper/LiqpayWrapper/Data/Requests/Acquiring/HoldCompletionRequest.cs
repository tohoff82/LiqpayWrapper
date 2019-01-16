using Newtonsoft.Json;

namespace LiqpayWrapper.Data.Requests.Acquiring
{
    public class HoldCompletionRequest : BaseRequest
    {
        [JsonProperty("amount")]
        public decimal Amount { get; set; }

        [JsonProperty("order_id")]
        public string OrderId { get; set; }
    }
}
