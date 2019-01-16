using LiqpayWrapper.Data.Requests;
using LiqpayWrapper.Data.Responses;

namespace LiqpayWrapper
{
    interface ILiqpayClient
    {
        StatusResponse GetStatus(StatusRequest model);

        OtpVerifyResponse OtpVerify(OtpVerifyRequest model);

        Verify3DsResponse Verify3Ds(Verify3DsRequest model);
    }
}
