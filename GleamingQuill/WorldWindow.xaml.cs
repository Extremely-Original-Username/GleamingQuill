using System;
using System.Collections.Generic;
using System.Linq;
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
        }
    }
}
