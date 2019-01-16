using Newtonsoft.Json;

namespace LiqpayWrapper.Data.Requests
{
    public abstract class BaseRequest
    {
        [JsonProperty("version")]
        public int Version { get; set; }

        [JsonProperty("public_key")]
        public string PublicKey { get; set; }

        [JsonProperty("action")]
        public string Action { get; set; }

        [JsonIgnore]
        public string PrivateKey { get; set; }
    }
}
