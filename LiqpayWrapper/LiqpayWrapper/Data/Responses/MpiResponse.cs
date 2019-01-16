using Newtonsoft.Json;

namespace LiqpayWrapper.Data.Responses
{
    public class MpiResponse : BaseResponse
    {
        [JsonProperty("mpi_req_pareq")]
        public string MpiReqPareq { get; private set; }

        [JsonProperty("mpi_req_md")]
        public string MpiReqMd { get; private set; }

        [JsonProperty("mpi_req_url")]
        public string MpiReqUrl { get; private set; }

        [JsonProperty("mpi_status")]
        public string MpiStatus { get; private set; }
    }
}
