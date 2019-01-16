using Newtonsoft.Json;

namespace LiqpayWrapper.Data.Requests
{
    public class P2PRequest : P2PCreditRequest
    {
        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("card")]
        public string Card { get; set; }

        [JsonProperty("card_exp_month")]
        public string CardExpMonth { get; set; }

        [JsonProperty("card_exp_year")]
        public string CardExpYear { get; set; }

        [JsonProperty("card_cvv")]
        public string CardCvv { get; set; }

        [JsonProperty("prepare", NullValueHandling = NullValueHandling.Ignore)]
        public string Prepare { get; set; }

        // ------------- 3DSParameters
        [JsonProperty("mpi_pares", NullValueHandling = NullValueHandling.Ignore)]
        public string MpiPares { get; set; }

        [JsonProperty("mpi_md", NullValueHandling = NullValueHandling.Ignore)]
        public string MpiMd { get; set; }
    }
}
