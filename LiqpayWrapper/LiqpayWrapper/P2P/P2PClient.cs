using System.Threading.Tasks;
using LiqpayWrapper.Data.Requests;
using LiqpayWrapper.Data.Responses;

namespace LiqpayWrapper.P2P
{
    public class P2PClient : LiqpayClient, IP2PClient
    {
        public P2PClient(string publicKey, string privateKey) : base(publicKey, privateKey) { }

        public async Task<P2PResponse> P2P(P2PRequest model)
        {
            model.Action = "p2p";
            return await Task.Run(() => Query<P2PResponse>(model));
        }

        public async Task<P2PCreditResponse> P2PCredit(P2PCreditRequest model)
        {
            model.Action = "p2pcredit";
            return await Task.Run(() => Query<P2PCreditResponse>(model));
        }
    }
}
