using Infraestructure.Models;
using Microsoft.Extensions.Configuration;
//using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Infraestructure.Client
{
    public class newsApiClient: InewsApiClient
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public newsApiClient(IConfiguration config, IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
       public async Task<NewsClientResponse> GetEverything(SearchRequest request)
        {
            var reply = new NewsClientResponse { status=null,totalResults = 0};
            var httpClient = _httpClientFactory.CreateClient("News");
            var response = await httpClient.GetAsync($"everything{request.makeUrl()}");
            if (response.IsSuccessStatusCode)
            {
                var a = await response.Content.ReadAsStreamAsync();
                reply = await JsonSerializer.DeserializeAsync<NewsClientResponse>(a);
            }
            return reply;

        }

        public async Task<NewsClientResponse> GetTopHeadLines(TopHeadLinesRequest request)
        {
            var reply = new NewsClientResponse { status = null, totalResults = 0 };
            var httpClient = _httpClientFactory.CreateClient("News");
            var response = await httpClient.GetAsync($"top-headlines{request.makeUrl()}");
            if (response.IsSuccessStatusCode)
            {
                var a = await response.Content.ReadAsStreamAsync();
                reply = await JsonSerializer.DeserializeAsync<NewsClientResponse>(a);
            }
            return reply;

        }
    }
}
