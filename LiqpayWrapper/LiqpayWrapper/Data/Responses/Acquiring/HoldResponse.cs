using Newtonsoft.Json;

namespace LiqpayWrapper.Data.Responses.Acquiring
{
    public class HoldResponse : AcquirerResponse
    {
        [JsonProperty("redirect_to")]
        public string RedirectTo { get; set; }

        [JsonProperty("token")]
        public string Token { get; set; }

        [JsonProperty("card_token")]
        public string CardToken { get; set; }
    }
}
