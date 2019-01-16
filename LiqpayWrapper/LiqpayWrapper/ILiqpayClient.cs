using System.Threading.Tasks;
using LiqpayWrapper.Data.Requests;
using LiqpayWrapper.Data.Responses;

namespace LiqpayWrapper
{
    interface ILiqpayClient
    {
        Task<StatusResponse> GetStatusAsync(StatusRequest model);

        Task<OtpVerifyResponse> OtpVerifyAsync(OtpVerifyRequest model);

        Task<Verify3DsResponse> Verify3DsAsync(Verify3DsRequest model);
    }
}
