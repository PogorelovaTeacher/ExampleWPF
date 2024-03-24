using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace WpfAppControl.View
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class WindowTreeView : Window
    {

        readonly DispatcherTimer dispatcherTimer;
        public WindowTreeView()
        {
            InitializeComponent();

            // Инициализация и запуск таймера.
            dispatcherTimer = new DispatcherTimer();
            dispatcherTimer.Tick += DispatcherTimer_Tick;
            dispatcherTimer.Interval = new TimeSpan(0, 0, 0, 0, 100);
            dispatcherTimer.Start();
        }

        private void DispatcherTimer_Tick(object sender, EventArgs e)
        {
            string str = "Текущее время: " + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second;
            textBlockTime.Text = str;
        }

                     

        private void TreeViewItem_Expanded(object sender, RoutedEventArgs e)
        {
            TreeViewItem treeViewItem = (TreeViewItem)sender;
            MessageBox.Show("Узел " + treeViewItem.Header.ToString() + " раскрыт");
        }

        private void TreeViewItem_Selected(object sender, RoutedEventArgs e)
        {
            TreeViewItem treeViewItem = (TreeViewItem)sender;
            MessageBox.Show("Выбран узел: " + treeViewItem.Header.ToString());
        }

        private void TreeViewItem_Selected_1(object sender, RoutedEventArgs e)
        {
            TreeViewItem treeViewItem = (TreeViewItem)sender;
            StackPanel stackPanel = treeViewItem.Header as StackPanel;
            string st = (stackPanel.Children[1] as TextBlock).Text;
            MessageBox.Show(st);
            
        }

        private void TreeViewItem_Selected_2(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Выбран узел: " + JavaScript.Name);
        }

        private void calendarExample_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            //DateTime? selectedDate = calendarExample.SelectedDate;
            //MessageBox.Show(selectedDate.Value.Date.ToShortDateString());
            List<DateTime> selectedDates = calendarExample.SelectedDates.ToList();
            StringBuilder dates = new StringBuilder("Выделенные даты");
            dates.AppendLine();
            foreach (DateTime date in selectedDates)
            {
                dates.AppendLine(date.ToShortDateString());
            }
            MessageBox.Show(dates.ToString());
        }
    }
}
