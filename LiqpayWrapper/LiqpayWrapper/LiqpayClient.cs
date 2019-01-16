using System;
using System.Net;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;
using System.Security.Cryptography;
using LiqpayWrapper.Data.Requests;
using LiqpayWrapper.Data.Responses;
using LiqpayWrapper.Helper;
using RestSharp;

namespace LiqpayWrapper
{
    public abstract class LiqpayClient : ILiqpayClient
    {
        protected readonly string PubKey;
        protected readonly string PrivKey;
        private const int ApiVersion = 3;
        protected const string BaseUrl = "https://www.liqpay.com/api/request";

        protected LiqpayClient(string pubKey, string privKey)
        {
            PubKey = pubKey;
            PrivKey = privKey;
        }

        public virtual async  Task<StatusResponse> GetStatusAsync(StatusRequest model)
        {
            model.Action = "status";
            return await Query<StatusResponse>(model);
        }

        public virtual async Task<OtpVerifyResponse> OtpVerifyAsync(OtpVerifyRequest model)
        {
            model.Action = "otp_verify";
            return await Query<OtpVerifyResponse>(model);
        }

        public virtual async Task<Verify3DsResponse> Verify3DsAsync(Verify3DsRequest model)
        {
            model.Action = "3ds_verify";
            return await Query<Verify3DsResponse>(model);
        }



        protected virtual async Task<T> Query<T>(BaseRequest model) where T : BaseResponse, new()
        {
            model.Version = ApiVersion;

            if (model.PublicKey == null) model.PublicKey = PubKey;

            var requestModel = new
            {
                data = await ToPackAsync(model),
                signature = await CreateSignatureAsync(ToPackAsync(model).Result, PrivKey)
            };

            var response = await HttpPostAsync<T>(BaseUrl, requestModel, 60000);

            if (response.StatusCode != HttpStatusCode.OK) throw new HttpRequestException(response.StatusCode.ToString());

            return response.Data;
        }

        private async Task<string> ToPackAsync(BaseRequest model) => await model.ToJson().ToBase64();

        private async Task<string> CreateSignatureAsync(string postData, string secret)
        {
            var sb = new StringBuilder(secret).Append(postData).Append(secret);
            using (var sha1 = SHA1.Create())
            {
                byte[] sha1Res = sha1.ComputeHash(Encoding.UTF8.GetBytes(sb.ToString()));

                return await Task.Run(() => Convert.ToBase64String(sha1Res));
            }
                
        }

        private async Task<IRestResponse<T>> HttpPostAsync<T>(string url, object data, int timeout) where T : new()
        {
            var request = CreateRequest(Method.POST, timeout);
            var client = new RestClient(url);
            request.AddObject(data);
            return await Task.Run(() => client.Execute<T>(request));
        }

        private static RestRequest CreateRequest(Method method, int timeout = 30000)
        {
            return new RestRequest
            {
                Method = method,
                RequestFormat = DataFormat.Json,
                Timeout = timeout
            };
        }
    }
}
