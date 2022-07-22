﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Models
{
    public class NewsClientResponse
    {
        public string status { get; set; }
        public int totalResults { get; set; }
        public List<Article> articles { get; set; }

    }

    public partial class Article
    {
        public Source source { get; set; }
        public string author { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string url { get; set; }
        public string urlToImage { get; set; }
        public DateTime publishedAt { get; set; }
        public string content { get; set; }
    }


    public partial class Source
    {
        public string id { get; set; }
        public string name { get; set; }
    }
}
