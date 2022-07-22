using Infraestructure.Client;
using Infraestructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Implementation
{
    public class NewsServices : INewsServices
    {
        private readonly InewsApiClient _newsApiClient;

        public NewsServices(InewsApiClient newsApiClient)
        {
            _newsApiClient = newsApiClient;
        }
        public async Task<NewsClientResponse> GetEverything(SearchRequest request)
        {
            return await _newsApiClient.GetEverything(request);
        }

        public async Task<NewsClientResponse> GetTopHeadLines(TopHeadLinesRequest request)
        {
            return await _newsApiClient.GetTopHeadLines(request);
        }

    }
}
