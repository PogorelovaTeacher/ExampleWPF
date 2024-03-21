using System;
using System.Collections.Generic;
using System.IO;
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
using WpfAppControl.Classes;

namespace WpfAppControl.View
{
    /// <summary>
    /// Логика взаимодействия для WindowListBox.xaml
    /// </summary>
    public partial class WindowListBox : Window
    {
        List<string> listCollection = new List<string>();
        StreamReader streamCollection = new StreamReader("persons.txt");
        public WindowListBox()
        {
            InitializeComponent();
            FillCollection(listCollection, streamCollection);
            listBoxAutofill.ItemsSource = listCollection;
            ListViewPerson.ItemsSource = new List<Person>
            {
                new Person {Name="Алиса", Age=30},
                new Person {Name="Миша", Age=40},
                new Person {Name="Дима", Age=23}
            };
            comboBoxName.IsEditable = true;
        }

        private void FillCollection(List<string> list, StreamReader stream)
        {
            while (!stream.EndOfStream) 
            { 
                string line = stream.ReadLine();
                list.Add(line);
            }
        }

        private void buttonAdd_Click(object sender, RoutedEventArgs e)
        {
            var item = listBoxPerson.SelectedValue;
            listBoxPerson.Items.Add(item);
        }

        private void buttonDel_Click(object sender, RoutedEventArgs e)
        {
            var item = listBoxAutofill.SelectedValue.ToString();
            listCollection.Remove(item);
            listBoxAutofill.Items.Refresh();
            
        }
    }
}
