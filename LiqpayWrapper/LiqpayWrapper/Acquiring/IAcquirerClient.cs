using System;
using System.Threading.Tasks;
using LiqpayWrapper.Data.Requests;
using LiqpayWrapper.Data.Requests.Acquiring;
using LiqpayWrapper.Data.Responses.Acquiring;
using LiqpayWrapper.Data.Responses;

namespace LiqpayWrapper.Acquiring
{
    interface IAcquirerClient : ILiqpayClient
    {
        Task<HoldResponse> HoldAsync(HoldRequest model);

        Task<HoldCompletionResponse> HoldCompletionAsync(HoldCompletionRequest model);

        Task<PayResponse> PayAsync(PayRequest model);

        Task<SubscribeResponse> SubscribeAsync(SubscribeRequest model);

        Task<UnsubscribeResponse> UnsubscribeAsync(UnsubscribeRequest model);

        Task<MpiResponse> MpiAsync(MpiRequest model);

        Task<AcquirerResponse> RefundAsync(RefundRequest model);

        Task<ReportResponse> ReportsAsync(DateTime dateFrom, DateTime dateTo);

        Task<AuthResponse> AuthAsync(AuthRequest model);
    }
}
