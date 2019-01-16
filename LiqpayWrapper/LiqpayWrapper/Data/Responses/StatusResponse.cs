using Newtonsoft.Json;

namespace LiqpayWrapper.Data.Responses
{
   public class StatusResponse : BasePaymentResponse
    {
        [JsonProperty("token")]
        public string Token { get; private set; }

        [JsonProperty("card_token")]
        public string CardToken { get; private set; }
    }
}
