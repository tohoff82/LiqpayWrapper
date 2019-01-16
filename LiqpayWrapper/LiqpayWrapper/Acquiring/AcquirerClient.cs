using System;
using System.Threading.Tasks;
using LiqpayWrapper.Data.Requests;
using LiqpayWrapper.Data.Responses;
using LiqpayWrapper.Data.Requests.Acquiring;
using LiqpayWrapper.Data.Responses.Acquiring;

namespace LiqpayWrapper.Acquiring
{
    public class AcquirerClient : LiqpayClient, IAcquirerClient
    {
        public AcquirerClient(string publicKey, string privateKey) : base(publicKey, privateKey) { }

        public async Task<AuthResponse> AuthAsync(AuthRequest model)
        {
            model.Action = "auth";
            return await Query<AuthResponse>(model);
        }

        public async Task<HoldResponse> HoldAsync(HoldRequest model)
        {
            model.Action = "hold";
            return await Query<HoldResponse>(model);
        }

        public async Task<HoldCompletionResponse> HoldCompletionAsync(HoldCompletionRequest model)
        {
            model.Action = "hold_completion";
            return await Query<HoldCompletionResponse>(model);
        }

        public async Task<MpiResponse> MpiAsync(MpiRequest model)
        {
            model.Action = "mpi";
            return await Query<MpiResponse>(model);
        }

        public async Task<PayResponse> PayAsync(PayRequest model)
        {
            model.Action = "pay";
            model.RecurringByToken = "1";
            return await Query<PayResponse>(model);
        }

        public async Task<AcquirerResponse> RefundAsync(RefundRequest model)
        {
            model.Action = "refund";
            return await Query<AcquirerResponse>(model);
        }

        public async Task<ReportResponse> ReportsAsync(DateTime dateFrom, DateTime dateTo)
        {
            var model = new ReportRequest
            {
                Action = "reports",
                DateFrom = GetTimestamp(dateFrom),
                DateTo = GetTimestamp(dateTo)
            };
            return await Query<ReportResponse>(model);
        }

        public async Task<SubscribeResponse> SubscribeAsync(SubscribeRequest model)
        {
            model.Action = "subscribe";
            return await Query<SubscribeResponse>(model);
        }

        public async Task<UnsubscribeResponse> UnsubscribeAsync(UnsubscribeRequest model)
        {
            model.Action = "unsubscribe";
            return await Query<UnsubscribeResponse>(model);
        }

        private static string GetTimestamp(DateTime date) => 
            ((long)date.Subtract(new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalMilliseconds/1000).ToString();
    }
}
