using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace GleamingQuill.Model.ArticleElements
{
    public class LongText : IArticleElement
    {
        public void addToPage(Panel page)
        {
            RichTextBox content = new RichTextBox();
            page.Children.Add(content);
        }
    }
}
