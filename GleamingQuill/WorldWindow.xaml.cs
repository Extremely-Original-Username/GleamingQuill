using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using GleamingQuill.Data;
using GleamingQuill.Model;

namespace GleamingQuill
{
    /// <summary>
    /// Interaction logic for WorldWindow.xaml
    /// </summary>
    public partial class WorldWindow : Window
    {
        private WorldContext worldContext { get; set; }

        public WorldWindow(string worldName)
        {
            InitializeComponent();

            this.Title = worldName;

            worldContext = new WorldContext(worldName);
            worldContext.Database.EnsureCreated();

            StackPanel articlExplorerContentPanel = new StackPanel();
            articleExplorer.Content = articlExplorerContentPanel;

            foreach (Article article in worldContext.articles)
            {
                articlExplorerContentPanel.Children.Add(createArticlePanel(article.Name));
            }
        }

        private StackPanel createArticlePanel(string content)
        {
            StackPanel panel = new StackPanel()
            {
                Width = 240,
                Height = 50,
                Margin = new Thickness(5),
                Background = new SolidColorBrush(Colors.LightGray)
            };

            panel.Children.Add(
                new TextBlock() { Text = content }
            );

            return panel;
        }
    }
}
