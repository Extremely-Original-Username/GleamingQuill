using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace GleamingQuill.Model.ArticleElements
{
    public interface IArticleElement
    {
        public void addToPage(Panel page);
    }
}
