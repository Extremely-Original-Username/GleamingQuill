using GleamingQuill.Model.ArticleElements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GleamingQuill.Model
{
    public class ArticleTypeDef
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public List<IArticleElement> Elements { get; set; }
    }
}
