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

            TextBox inputBox = createTextBox("World1", 5);

            //BUTTON creation
            Button newWorldButton = createButton("New World", 4, (object sender, RoutedEventArgs e) => {
                Application.Current.MainWindow = new WorldWindow(inputBox.Text);
                Application.Current.MainWindow.Show();
                this.Close();
            });

            Button loadWorldButton = createButton("Load World", 6, (object sender, RoutedEventArgs e) => {
                Application.Current.MainWindow = new WorldWindow(inputBox.Text);
                Application.Current.MainWindow.Show();
                this.Close();
            });
        }

        private Button createButton(string buttonName, int rowNum, Action<object, RoutedEventArgs> onClick)
        {
            Button button = new Button();
            button.Content = buttonName;
            button.Click += (object sender, RoutedEventArgs e) => { onClick(sender, e); };

            MainGrid.Children.Add(button);

            Grid.SetColumn(button, 1);
            Grid.SetRow(button, rowNum);

            return button;
        }

        private TextBox createTextBox(string boxName, int rowNum)
        {
            TextBox textBox = new TextBox();
            textBox.Text = boxName;

            MainGrid.Children.Add(textBox);

            Grid.SetColumn(textBox, 1);
            Grid.SetRow(textBox, rowNum);

            return textBox;
        }
    }
}
