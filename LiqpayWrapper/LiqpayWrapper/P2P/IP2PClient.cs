using System.Threading.Tasks;
using LiqpayWrapper.Data.Requests;
using LiqpayWrapper.Data.Responses;

namespace LiqpayWrapper.P2P
{
    interface IP2PClient : ILiqpayClient
    {
        Task<P2PResponse> P2PAsync(P2PRequest model);

        Task<P2PCreditResponse> P2PCreditAsync(P2PCreditRequest model);
    }
}
