using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TiktokAPI.User
{
    internal class Follow
    {
        public static async Task<string> FromUserID(long userID, string sessionID)
        {
            var handler = new HttpClientHandler();
            CookieContainer cont = new CookieContainer();
            handler.CookieContainer = cont;

            cont.Add(new Uri(API.FollowUrl), new Cookie("sessionid", sessionID.ToString()));

            HttpClient client = new HttpClient(handler);

            StringContent content = new StringContent("follow_type=1&to_user_id=" + userID + "", Encoding.UTF8, "application/x-www-form-urlencoded");

            var Follow = await client.PostAsync(API.FollowUrl, content).Result.Content.ReadAsStringAsync();

            return Follow;
        }
        public static async Task<string> FromUsername(string Username, string sessionID)
        {
            var findID = User.IdConverter.Check(Username).Result;

            var handler = new HttpClientHandler();
            CookieContainer cont = new CookieContainer();
            handler.CookieContainer = cont;

            cont.Add(new Uri(API.FollowUrl), new Cookie("sessionid", sessionID.ToString()));

            HttpClient client = new HttpClient(handler);

            StringContent content = new StringContent("follow_type=1&to_user_id=" + findID + "", Encoding.UTF8, "application/x-www-form-urlencoded");

            var Follow = await client.PostAsync(API.FollowUrl, content).Result.Content.ReadAsStringAsync();

            return Follow;
        }
    }
}
