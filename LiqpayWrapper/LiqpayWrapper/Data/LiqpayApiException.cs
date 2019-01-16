using System.Net.Http;

namespace LiqpayWrapper.Data
{
    public class LiqpayApiException : HttpRequestException
    {
        public LiqpayApiException() : base() { }
    }
}
