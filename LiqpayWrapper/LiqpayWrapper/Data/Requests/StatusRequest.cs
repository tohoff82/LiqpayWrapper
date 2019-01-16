using Newtonsoft.Json;

namespace LiqpayWrapper.Data.Requests
{
    public class StatusRequest : BaseRequest
    {
        [JsonProperty("order_id")]
        public string OrderId { get; set; }
    }
}
