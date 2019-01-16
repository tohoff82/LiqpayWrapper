using System.Threading.Tasks;
using Newtonsoft.Json;

namespace LiqpayWrapper.Helper
{
    public static class Extensions
    {
        public static async Task<string> ToJson(this object obj) => await Task.Run(() => JsonConvert.SerializeObject(obj));
    }
}
