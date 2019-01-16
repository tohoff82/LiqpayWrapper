using Newtonsoft.Json;

namespace LiqpayWrapper.Data.Responses
{
    public class CallbackResponse : BaseResponse
    {
        [JsonProperty("redirect_to")]
        public string RedirectTo { get; private set; }

        [JsonProperty("token")]
        public string Token { get; private set; }

        [JsonProperty("card_token")]
        public string CardToken { get; private set; }

        [JsonProperty("status")]
        public string Status { get; private set; }
    }
}
