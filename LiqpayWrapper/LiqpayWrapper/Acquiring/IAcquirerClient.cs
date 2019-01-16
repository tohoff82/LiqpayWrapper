using System;
using LiqpayWrapper.Data.Requests;
using LiqpayWrapper.Data.Requests.Acquiring;
using LiqpayWrapper.Data.Responses.Acquiring;
using LiqpayWrapper.Data.Responses;

namespace LiqpayWrapper.Acquiring
{
    interface IAcquirerClient : ILiqpayClient
    {
        HoldResponse Hold(HoldRequest model);

        HoldCompletionResponse HoldCompletion(HoldCompletionRequest model);

        PayResponse Pay(PayRequest model);

        SubscribeResponse Subscribe(SubscribeRequest model);

        UnsubscribeResponse Unsubscribe(UnsubscribeRequest model);

        MpiResponse Mpi(MpiRequest model);

        AcquirerResponse Refund(RefundRequest model);

        ReportResponse Reports(DateTime dateFrom, DateTime dateTo);

        AuthResponse Auth(AuthRequest model);
    }
}
