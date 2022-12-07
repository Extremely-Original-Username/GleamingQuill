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

namespace GleamingQuill
{
    /// <summary>
    /// Interaction logic for StartWindow.xaml
    /// </summary>
    public partial class StartWindow : Window
    {
        public StartWindow()
        {
            InitializeComponent();

            //BUTTON creation
            Button newWorldButton = createButton("New World");
            //newWorldButton.Margin = new Thickness(0, 0, 0, 120);
            Button loadWorldButton = createButton("Load World");
            //loadWorldButton.Margin = new Thickness(0, 40, 0, 0);

            MainGrid.Children.Add(newWorldButton);
            MainGrid.Children.Add(loadWorldButton);

            //BUTTON logic
            newWorldButton.Click += (object sender, RoutedEventArgs e) => {
                Application.Current.MainWindow = new WorldWindow("");
                Application.Current.MainWindow.Show();
                this.Close();
            };

            loadWorldButton.Click += (object sender, RoutedEventArgs e) => {
                Application.Current.MainWindow = new WorldWindow("");
                Application.Current.MainWindow.Show();
                this.Close();
            };
        }

        private Button createButton(string buttonName)
        {
            return new Button()
            {
                Width = 140,
                Height = 30,
                Content = buttonName,
            };
        }
    }
}
