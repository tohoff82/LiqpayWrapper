using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace LiqpayWrapper.Data.Responses
{
    public class BasePaymentResponse : BaseResponse
    {
        [JsonProperty("status")]
        public string Status { get; private set; }

        [JsonProperty("type")]
        public string Type { get; private set; }

        [JsonProperty("err_erc")]
        public string ErrErc { get; private set; }

        [JsonProperty("payment_id")]
        public int PaymentId { get; private set; }

        [JsonProperty("public_key")]
        public string PublicKey { get; private set; }

        [JsonProperty("acq_id")]
        public int AcqId { get; private set; }

        [JsonProperty("order_id")]
        public string OrderId { get; private set; }

        [JsonProperty("liqpay_order_id")]
        public string LiqpayOrderId { get; private set; }

        [JsonProperty("description")]
        public string Description { get; private set; }

        [JsonProperty("sender_phone")]
        public string SenderPhone { get; private set; }

        [JsonProperty("sender_card_mask2")]
        public string SenderCardMask2 { get; private set; }

        [JsonProperty("sender_card_bank")]
        public string SenderCardBank { get; private set; }

        [JsonProperty("sender_card_country")]
        public int SenderCardCountry { get; private set; }

        [JsonProperty("ip")]
        public string Ip { get; private set; }

        [JsonProperty("info")]
        public string Info { get; private set; }

        [JsonProperty("customer")]
        public string Customer { get; private set; }

        [JsonProperty("amount")]
        public int Amount { get; private set; }

        [JsonProperty("currency")]
        [JsonConverter(typeof(StringEnumConverter))]
        public string Currency { get; private set; }

        [JsonProperty("sender_commission")]
        public decimal SenderCommission { get; private set; }

        [JsonProperty("receiver_commission")]
        public decimal ReceiverCommission { get; private set; }

        [JsonProperty("agent_commission")]
        public decimal AgentCommission { get; private set; }

        [JsonProperty("amount_debit")]
        public int AmountDebit { get; private set; }

        [JsonProperty("amount_credit")]
        public int AmountCredit { get; private set; }

        [JsonProperty("commission_debit")]
        public decimal CommissionDebit { get; private set; }

        [JsonProperty("commission_credit")]
        public decimal CommissionCredit { get; private set; }

        [JsonProperty("currency_debit")]
        public string CurrencyDebit { get; private set; }

        [JsonProperty("currency_credit")]
        public string CurrencyCredit { get; private set; }

        [JsonProperty("sender_bonus")]
        public decimal SenderBonus { get; private set; }

        [JsonProperty("amount_bonus")]
        public decimal AmountBonus { get; private set; }

        [JsonProperty("refund_amount")]
        public decimal RefundAmount { get; private set; }

        [JsonProperty("completion_date")]
        public string CompletionDate { get; private set; }

        [JsonProperty("authcode_debit")]
        public string AuthcodeDebit { get; private set; }

        [JsonProperty("authcode_credit")]
        public string AuthcodeCredit { get; private set; }

        [JsonProperty("rrn_debit")]
        public string RrnDebit { get; private set; }

        [JsonProperty("rrn_credit")]
        public string RrnCredit { get; private set; }

        [JsonProperty("arrn_debit")]
        public string ArrnDebit { get; private set; }

        [JsonProperty("arrn_credit")]
        public string ArrnCredit { get; private set; }

        [JsonProperty("verifycode")]
        public string Verifycode { get; private set; }

        [JsonProperty("action")]
        public string Action { get; private set; }

        [JsonProperty("is_3ds")]
        public bool Is3Ds { get; private set; }
    }
}
