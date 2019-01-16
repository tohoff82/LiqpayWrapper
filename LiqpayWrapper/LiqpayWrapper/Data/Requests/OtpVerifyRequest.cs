using Newtonsoft.Json;

namespace LiqpayWrapper.Data.Requests
{
   public class OtpVerifyRequest : BaseRequest
    {
        [JsonProperty("token")]
        public string Token { get; set; }

        [JsonProperty("otp")]
        public string Otp { get; set; }
    }
}
