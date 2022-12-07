using GleamingQuill.Model.ArticleElements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GleamingQuill.Model
{
    public class Article
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public List<IArticleElement> Elements { get; set; }

        //FOR CREATING NEW ARTICLE
        public Article(string Name, ArticleTypeDef layoutTemplate)
        {
            this.Id = Guid.NewGuid();
            this.Name = Name;
            Elements = new List<IArticleElement>();

            foreach (IArticleElement element in layoutTemplate.Elements)
            {
                Elements.Add(element);
            }
        }

        //FOR LOADING EXISTING ARTICLE
        //public Article(Guid Id, string Name, List<IArticleElement> Elements)
        //{
        //    this.Id = Id;
        //    this.Name = Name;
        //    this.Elements = Elements;
        //}
    }
}
