using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Models
{
    public class TopHeadLinesRequest
    {
        public string Country { get; set; } = "ar";
        public int page { get; set; }
        public int pageSize { get; set; }

        public string makeUrl()
        {
            string url = $"?country={this.Country}";
            if (page != 0)
                url += $"&page={this.page}";
            if (pageSize != 0)
                url += $"&pageSize={this.pageSize}";
            return url;
        }
    }
}
