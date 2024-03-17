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

namespace WpfAppControl.View
{
    /// <summary>
    /// Логика взаимодействия для WindowLayout.xaml
    /// </summary>
    public partial class WindowLayout : Window
    {
        Random random = new Random(255);
        Random random2 = new Random(50);
        public WindowLayout()
        {
            InitializeComponent();
        }

        private void ButtonChangeColor_Click(object sender, RoutedEventArgs e)
        {
            
            Color color =  Color.FromRgb((byte)random.Next(), (byte)random.Next(), (byte)random.Next());
            CanvasColor.Background = new SolidColorBrush(color);
            ButtonChangeColor.Content = "Actual color = "+color;
        }
    }
}
