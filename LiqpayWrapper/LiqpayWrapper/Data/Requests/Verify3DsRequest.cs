using Newtonsoft.Json;

namespace LiqpayWrapper.Data.Requests
{
    public class VerifyRequest : BaseRequest
    {
        [JsonProperty("token", NullValueHandling = NullValueHandling.Ignore)]
        public string Token { get; set; }
    }
}
