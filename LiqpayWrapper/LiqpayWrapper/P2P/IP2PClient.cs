using LiqpayWrapper.Data.Requests;
using LiqpayWrapper.Data.Responses;

namespace LiqpayWrapper.P2P
{
    interface IP2PClient : ILiqpayClient
    {
        P2PResponse P2P(P2PRequest model);

        P2PCreditResponse P2PCredit(P2PCreditRequest model);
    }
}
