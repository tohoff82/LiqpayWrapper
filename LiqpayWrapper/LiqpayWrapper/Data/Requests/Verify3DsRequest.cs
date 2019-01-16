using Newtonsoft.Json;

namespace LiqpayWrapper.Data.Requests
{
    public class Verify3DsRequest : BaseRequest
    {
        [JsonProperty("token", NullValueHandling = NullValueHandling.Ignore)]
        public string Token { get; set; }
    }
}
