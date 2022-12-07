using GleamingQuill.Model.ArticleElements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GleamingQuill.Model
{
    static public class ArticleTypeDefDEFAULTS
    {
        static ArticleTypeDef document = new ArticleTypeDef("Document", new List<IArticleElement>()
        {
            new LongText()
        });
    }
}
