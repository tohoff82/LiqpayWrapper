using Newtonsoft.Json;

namespace LiqpayWrapper.Data.Requests
{
    public class ReportRequest : BaseRequest
    {
        [JsonProperty("date_from")]
        public string DateFrom { get; set; }

        [JsonProperty("date_to")]
        public string DateTo { get; set; }
    }
}
