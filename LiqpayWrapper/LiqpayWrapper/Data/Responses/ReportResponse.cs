using Newtonsoft.Json;

namespace LiqpayWrapper.Data.Responses
{
    public class ReportResponse : BaseResponse
    {
        [JsonProperty("status")]
        public string Status { get; private set; }

        [JsonProperty("type")]
        public string PaymentType { get; private set; }

        [JsonProperty("token")]
        public string PaymentToken { get; private set; }

        [JsonProperty("card_token")]
        public string CardToken { get; private set; }

        [JsonProperty("payment_id")]
        public string PaymentId { get; private set; }

        [JsonProperty("order_id")]
        public string OrderId { get; private set; }

        [JsonProperty("amount")]
        public string Amount { get; private set; }

        [JsonProperty("agent_commission")]
        public string Commission { get; private set; }
    }
}
