using Infraestructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Implementation
{
    public interface INewsServices
    {
        Task<NewsClientResponse> GetEverything(SearchRequest request);
        Task<NewsClientResponse> GetTopHeadLines(TopHeadLinesRequest request);
    }
}
