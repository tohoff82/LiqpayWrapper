using Newtonsoft.Json;

namespace LiqpayWrapper.Data.Responses.Acquiring
{
    public class AcquirerResponse : BasePaymentResponse
    {
        [JsonProperty("product_url")]
        public string ProductUrl { get; private set; }

        [JsonProperty("product_category")]
        public string ProductCategory { get; private set; }

        [JsonProperty("product_name")]
        public string ProductName { get; private set; }

        [JsonProperty("product_description")]
        public string ProductDescription { get; private set; }
    }
}
