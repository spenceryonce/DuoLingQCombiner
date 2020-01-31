using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using Newtonsoft.Json;
using System.Threading;
using DuoLingQCombiner.Models;

namespace DuoLingQCombiner.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DuoWordController : ControllerBase
    {
        // GET: api/DuoWord
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        CancellationToken CancellationToken;

        // GET: api/DuoWord/5
        [HttpGet("{id}", Name = "Get")]
        public async Task<string> GetAsync(int id)
        {
            //string url = "https://www.duolingo.com/api/1/users/show?id=";
            //string processedUrl = url + id;
            //var client = new HttpClient();
            //client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("text/html"));
            //client.DefaultRequestHeaders.AcceptEncoding.Add(new StringWithQualityHeaderValue("gzip"));
            //client.DefaultRequestHeaders.AcceptLanguage.Add(new StringWithQualityHeaderValue("en-US"));
            //client.DefaultRequestHeaders.CacheControl = new CacheControlHeaderValue();
            //client.DefaultRequestHeaders.Pragma.Add(new NameValueHeaderValue("nocache"));
            ////client.DefaultRequestHeaders.UserAgent.Add(new ProductInfoHeaderValue("Mozilla"));

            //using (client)
            //using (var request = new HttpRequestMessage(HttpMethod.Get, processedUrl))
            //using (var response = await client.SendAsync(request))
            //{
            //    var content = await response.Content.ReadAsStringAsync();
            //    //return JsonConvert.DeserializeObject<string[]>(content);
            //    return content;

            //}

            using (var httpClient = new HttpClient())
            {
                using (var request = new HttpRequestMessage(new HttpMethod("GET"), "https://www.duolingo.com/api/1/users/show?id=456"))
                {
                    request.Headers.TryAddWithoutValidation("authority", "www.duolingo.com");
                    request.Headers.TryAddWithoutValidation("pragma", "no-cache");
                    request.Headers.TryAddWithoutValidation("cache-control", "no-cache");
                    request.Headers.TryAddWithoutValidation("upgrade-insecure-requests", "1");
                    request.Headers.TryAddWithoutValidation("user-agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/79.0.3945.130 Safari/537.36");
                    request.Headers.TryAddWithoutValidation("sec-fetch-user", "?1");
                    request.Headers.TryAddWithoutValidation("accept", "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3;q=0.9");
                    request.Headers.TryAddWithoutValidation("sec-fetch-site", "none");
                    request.Headers.TryAddWithoutValidation("sec-fetch-mode", "navigate");
                    request.Headers.TryAddWithoutValidation("accept-encoding", "gzip, deflate, br");
                    request.Headers.TryAddWithoutValidation("accept-language", "en-US,en;q=0.9");
                    request.Headers.TryAddWithoutValidation("cookie", "lang=en; wuuid=73d43fd4-773c-44b8-845e-31560ee0c119; lu=https://forum.duolingo.com/comment/2418289/Public-API-for-DuoLingo; initial_referrer=https://www.google.com/; _pxvid=34e45557-4374-11ea-b6f2-0242ac120009; lp=forum_comment; _ga=GA1.2.312020265.1580397746; _gid=GA1.2.865046199.1580397746; _fbp=fb.1.1580397745722.440912637; tsl=1580398038980; _px3=2c98b1e4baebdd6d4b36d8a7f601afa361eafdbeda0bb18e3fae41d049a3fca2:Vxb8+pxuryQ8XgZAZUtOQ3vKz/HG+XYak3k9DhLRCDZepLs+iHASKqutNBSlp8E/Kva4HV96C8pv4sFT8tW0zA==:1000:WyNmb0ZEP16MMkKtg7v3tW/M+0Kjpn95sVcNbkizKCKVSp0aGRFOG0evc8R28e5gBskM5nGY/C36VqlyufebsbTe+23Trx4VqXihl88t663lNL1NVzheV5f3/A1WGczAu8qwmpD6rN/VkDQ6dhDgePkX37mRDwAAB/imIBpYeF0=; G_ENABLED_IDPS=google; _gcl_au=1.1.976063975.1580398050; lr=; _pxhd=; jwt_token=eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJleHAiOjYzMDcyMDAwMDAsImlhdCI6MCwic3ViIjoxMzk4NDE2fQ.caBerAT4mFqdtr0T1JTe3nBBEmqBUO-pDGgXTyzm7N4; csrf_token=IjQ2NzA1MTc0ZDVhMjRiM2FhYTg0YjFjYzliMzM2ZTEzIg==; logged_out_uuid=1398416; logged_in=true; AWSALB=kq7X2ZQWOubEVSAoB/rnO4Unsk5/+gBya0/yMGuXirSGxRkxXW/spM/nFUEX1cEG8Y6502R8HWgdb1cZ237IERgOxuM59Wm34uqfTp/hej/5WQQ6Px2YYseL7bz4; AWSALBCORS=kq7X2ZQWOubEVSAoB/rnO4Unsk5/+gBya0/yMGuXirSGxRkxXW/spM/nFUEX1cEG8Y6502R8HWgdb1cZ237IERgOxuM59Wm34uqfTp/hej/5WQQ6Px2YYseL7bz4");

                    var response = await httpClient.SendAsync(request);

                    string res = response.StatusCode.ToString();
                    JsonSerializer js = JsonSerializer.CreateDefault();
                    //string content = js.Deserialize(response.Content);


                    return response.ToString();
                }
            }

        }

        







    // POST: api/DuoWord
        [HttpPut]
        public void Post([FromBody] string value)
        {
            
        }

        // POST: api/DuoWord/5
        [HttpPost("{id}")]
        public string Put(int id)
        {
            WordDataContext Wdc = new WordDataContext();
            WordList wordList = new WordList()
            {
                Id = 1,
                Language = "French",
                Words = new List<Word>()
            };

            Word testWord = new Word();
            testWord.Id = 5;
            testWord.NativeLanguage = "mister";
            testWord.TypeOfSpeech = TypeOfSpeech.Noun;
            testWord.ForeignLanguage = "monsieur";
            wordList.Words.Add(testWord);
            Wdc.WordLists.Add(wordList);
            Wdc.SaveChanges();
            string jsonData = JsonConvert.SerializeObject(wordList);

            return jsonData.ToString();
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
