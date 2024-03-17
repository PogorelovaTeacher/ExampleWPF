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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfAppControl.View
{
    public class Phone
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public override string ToString()
        {
            return $"{Name} цена: {Price}";
        }
    }

    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();

            Button createCodeButton = new Button();
            createCodeButton.Height = 25;
            createCodeButton.Width = 200;
            createCodeButton.Content = "CreateCodeButton";
            createCodeButton.HorizontalAlignment = HorizontalAlignment.Left;
            createCodeButton.VerticalAlignment = VerticalAlignment.Top;
            createCodeButton.Background = new SolidColorBrush(Colors.Aqua);
            createCodeButton.FontWeight = FontWeights.Bold;
            createCodeButton.Margin = new Thickness
            {
                Left = 50,
                Top = 50
            };
            MainGrid.Children.Add(createCodeButton);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Кнопка нажата");
        }

        private void ButtonClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void ButtonTransfer_Click(object sender, RoutedEventArgs e)
        {
            TextBoxOutput.Text = TextBoxInput.Text;
            TextBoxInput.Text = "";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
