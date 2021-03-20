using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BookClient.Data
{
    public class Book
    {
        public string ISBN { get; set; }
        public string Title { get; set; }
        public List<string> Authors { get; set; }
        public DateTime PublishDate { get; set; }
        public string Genre { get; set; }

        static readonly string BaseAddress = "{Url from before}";
        static readonly string Url = $"{BaseAddress}/api/books/";

        private string authorizationkey; //토큰 저장할 필드


        public async Task<HttpClient> GetClient()
        {
            HttpClient client = new HttpClient();

            if (string.IsNullOrEmpty(authorizationkey))
            {
                authorizationkey = await client.GetStringAsync(Url + "login");
                authorizationkey = JsonConvert.DeserializeObject<string>(authorizationkey);
            }

            client.DefaultRequestHeaders.Add("Authorization", authorizationkey);
            client.DefaultRequestHeaders.Add("Accept", "applicatoin/json");

            return client;

        }

    }


}

