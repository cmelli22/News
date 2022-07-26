using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Models
{
    public class SearchRequest
    {
        public string Keyword { get; set; }
        public string dateFrom { get; set; }
        public string dateTo { get; set; }
        public int? page { get; set; } = 0;
        public int pageSize { get; set; }


        public string makeUrl()
        {
            string url = $"?q={this.Keyword}";
            if (page != 0)
                url += $"&page={this.page}";
            if (pageSize != 0)
                url += $"&pageSize={this.pageSize}";
            if (!String.IsNullOrEmpty(dateFrom))
                url += $"&from={this.dateFrom}";
            if (!String.IsNullOrEmpty(dateTo))
                url += $"&to={this.dateTo}";
            return url;
        }
    }
}
