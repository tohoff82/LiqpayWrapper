using Newtonsoft.Json;

namespace LiqpayWrapper.Data
{
    public abstract class BaseResponse
    {
        [JsonProperty("err_code")]
        public string ErrCode { get; private set; }

        [JsonProperty("err_description")]
        public string ErrDescription { get; private set; }

        [JsonProperty("version")]
        public int Version { get; private set; }
    }
}
