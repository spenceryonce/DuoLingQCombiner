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
            string url = "https://www.duolingo.com/api/1/users/show?id=";
            string processedUrl = url + id;
            var client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("text/html"));
            client.DefaultRequestHeaders.AcceptEncoding.Add(new StringWithQualityHeaderValue("gzip"));
            client.DefaultRequestHeaders.AcceptLanguage.Add(new StringWithQualityHeaderValue("en-US"));
            client.DefaultRequestHeaders.CacheControl = new CacheControlHeaderValue();
            client.DefaultRequestHeaders.Pragma.Add(new NameValueHeaderValue("nocache"));
            //client.DefaultRequestHeaders.UserAgent.Add(new ProductInfoHeaderValue("Mozilla"));

            using (client)
            using (var request = new HttpRequestMessage(HttpMethod.Get, processedUrl))
            using (var response = await client.SendAsync(request))
            {
                var content = await response.Content.ReadAsStringAsync();
                //return JsonConvert.DeserializeObject<string[]>(content);
                return content;

            }

        }







    // POST: api/DuoWord
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/DuoWord/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
