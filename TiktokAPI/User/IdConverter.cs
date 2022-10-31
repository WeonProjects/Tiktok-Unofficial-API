using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace TiktokAPI.User
{
    internal class IdConverter
    {
        public static async Task<string> Check(string Username)
        {

            HttpClient client = new HttpClient();

            var Al = await client.GetStringAsync("https://countik.com/api/exist/" + Username + "");

            string id = Split(Al, "id\":\"", "\"");

            return id;
        }
        public static string Split(string source, string left, string right)
        {
            return source.Split(new string[]
            {
                left
            }, StringSplitOptions.None)[1].Split(new string[]
            {
                right
            }, StringSplitOptions.None)[0];
        }
    }
}
