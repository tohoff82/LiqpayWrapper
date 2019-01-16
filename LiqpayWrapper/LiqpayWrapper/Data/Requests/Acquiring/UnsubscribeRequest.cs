using Newtonsoft.Json;

namespace LiqpayWrapper.Data.Requests.Acquiring
{
    public class UnsubscribeRequest : BaseRequest
    {
        [JsonProperty("order_id")]
        public string OrderId { get; set; }
    }
}
