using System;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace LiqpayWrapper.Helper
{
    public static class Extensions
    {
        public static async Task<string> ToJson(this object obj) => await Task.Run(() => JsonConvert.SerializeObject(obj));

        public static string ToBase64(this Task<string> str) => Convert.ToBase64String(Encoding.UTF8.GetBytes(str.Result));
    }
}
