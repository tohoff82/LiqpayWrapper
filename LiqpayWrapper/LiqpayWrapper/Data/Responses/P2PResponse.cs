using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace LiqpayWrapper.Data.Responses
{
    public class P2PResponse : BasePaymentResponse
    {
        [JsonProperty("redirect_to")]
        public string RedirectTo { get; private set; }

        [JsonProperty("token")]
        public string Token { get; private set; }

        [JsonProperty("card_token")]
        public string CardToken { get; private set; }
    }
}
