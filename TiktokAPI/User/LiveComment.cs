using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TiktokAPI.User
{
    internal class LiveComment
    {
        public static async Task<string> FromRoomId(string Content, long roomId, string sessionID)
        {
            var handler = new HttpClientHandler();
            CookieContainer cont = new CookieContainer();
            handler.CookieContainer = cont;

            cont.Add(new Uri(API.FollowUrl), new Cookie("sessionid", sessionID.ToString()));

            HttpClient client = new HttpClient(handler);

            StringContent content = new StringContent($"room_id={roomId}&content={Content}", Encoding.UTF8, "application/x-www-form-urlencoded");

            var TakipEt = await client.PostAsync(API.FollowUrl, content).Result.Content.ReadAsStringAsync();

            return TakipEt;
        }
    }
}
