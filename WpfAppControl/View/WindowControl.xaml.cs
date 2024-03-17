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

namespace WpfAppControl.View
{
    /// <summary>
    /// Логика взаимодействия для WindowControl.xaml
    /// </summary>
    public partial class WindowControl : Window
    {
        Random random = new Random();
        Color getColor;
        public WindowControl()
        {
            InitializeComponent();
            //создание StackPanel 
            StackPanel stackPanelCode = new StackPanel();

            //создание кнопки с кнопкой внутри
            Button buttonBaseCode = new Button();
            buttonBaseCode.Content = new Button { Content = "IN", Name = "inButton"};
            (buttonBaseCode.Content as Button).Click +=
                (sender, e) => { MessageBox.Show("Нажата внутренняя кнопка"); };
            buttonBaseCode.Click += BaseButton_Click;
            buttonBaseCode.Margin = new Thickness { Left = 10, Top = 10, Bottom = 10, Right = 10 };

            //создание надписи
            Label labelCode = new Label { Content = "Created using code" };
            labelCode.HorizontalAlignment = HorizontalAlignment.Center;
            labelCode.FontWeight = FontWeights.Bold;

            //компановка элементов
            stackPanelCode.Children.Add(labelCode);
            stackPanelCode.Children.Add(buttonBaseCode);
            MyGridView.Children.Add(stackPanelCode);
            Grid.SetColumn(stackPanelCode, 1);

            //создание StackPanel с надписью и кнопками для размещения внутри кнопки
            StackPanel stackPanelInButton = new StackPanel();           
            stackPanelInButton.Children.Add(new TextBlock { Text = "Набор кнопок" });
            stackPanelInButton.Children.Add(new Button { Content = "1", Background = new SolidColorBrush(Colors.BlueViolet) });
            stackPanelInButton.Children.Add(new Button { Content = "2", Background = new SolidColorBrush(Colors.CadetBlue) });
            stackPanelInButton.Children.Add(new Button 
            { 
                Content = "3", 
                Background = new SolidColorBrush(Colors.Cyan),
                HorizontalContentAlignment = HorizontalAlignment.Right,
                Padding = new Thickness { Left = 10, Top = 10, Bottom = 10, Right = 10 }
            });

            // создание кнопки с несколькими элементами внутри
            Button buttonCodeWithMultyEltments = new Button();
            buttonCodeWithMultyEltments.Margin = new Thickness
            {
                Bottom = 10,
                Top = 0,
                Left = 10,
                Right = 10
            };
            buttonCodeWithMultyEltments.Content = stackPanelInButton;
            stackPanelCode.Children.Add(buttonCodeWithMultyEltments);

            // создание CheckBox
            CheckBox checkBoxCode = new CheckBox 
            {
                Content = "Неопределенное состояние",
                IsThreeState = true,
                IsChecked = null,
                MinHeight = 25,
                MinWidth = 100,
                VerticalContentAlignment = VerticalAlignment.Center,
                Background = new SolidColorBrush(Colors.Aqua)                               
            };
            checkBoxCode.Checked += checkBoxState_Checked;
            checkBoxCode.Unchecked += checkBoxState_Unchecked;
            checkBoxCode.Indeterminate += checkBoxState_Indeterminate;

            stackPanelCode.Children.Add(checkBoxCode);

            //создание RadioButton
            RadioButton radioButtonCode1 = new RadioButton 
            { 
                IsChecked = true, 
                GroupName = "Languages", 
                Content = "JavaScript" 
            };
            radioButtonCode1.Checked += RadioButton_Checked;
            RadioButton radioButtonCode2 = new RadioButton { GroupName = "Languages", Content = "Kotlin" };
            radioButtonCode2.Checked += RadioButton_Checked;
            stackPanelCode.Children.Add(radioButtonCode1);
            stackPanelCode.Children.Add(radioButtonCode2);

            //создание подсказки для кнопки
            ToolTip toolTip = new ToolTip();
            StackPanel stackPanelToolTip = new StackPanel();
            stackPanelToolTip.Orientation = Orientation.Horizontal;
                        
            Uri uri = new Uri("/Images/microscope.jpg", UriKind.RelativeOrAbsolute);
            stackPanelToolTip.Children.Add(new Image { Source = new BitmapImage(uri)});
            stackPanelToolTip.Children.Add(new Label { Content = "Жми сюда " });
            toolTip.Content = stackPanelToolTip;
            buttonCodeWithMultyEltments.ToolTip = toolTip;

            Image image = new Image 
            { 
                Source = new BitmapImage(uri),
                Height = 50,
                Width = 50,
                //Stretch = Stretch.None
            };
           
            stackPanelCode.Children.Add(image);

            // создание экспандера
            StackPanel expanderPanel = new StackPanel();
            RadioButton expanderRB1 = new RadioButton
            {
                Height = 20,
                Width = 50,
                HorizontalAlignment = HorizontalAlignment.Left,
                GroupName = "1",
                Content = new Label { Height = 20, Width = 50, Background = new SolidColorBrush(Colors.Cyan)},
            };
            expanderRB1.Checked += ExpanderRB_Checked;
            RadioButton expanderRB2 = new RadioButton
            {
                Height = 20,
                Width = 50,
                HorizontalAlignment = HorizontalAlignment.Left,
                GroupName = "1",
                Content = new Label { Height = 20, Width = 50, Background = new SolidColorBrush(Colors.RosyBrown)}
            };
            expanderRB2.Checked += ExpanderRB_Checked;
            RadioButton expanderRB3 = new RadioButton
            {
                Height = 20,
                Width = 50,
                HorizontalAlignment = HorizontalAlignment.Left,
                GroupName = "1",
                Content = new Label { Height = 20, Width = 50, Background = new SolidColorBrush(Colors.Green)}
            };
            expanderRB3.Checked += ExpanderRB_Checked;
            expanderPanel.Children.Add(expanderRB1);
            expanderPanel.Children.Add(expanderRB2);
            expanderPanel.Children.Add(expanderRB3);
            
            Image imageExpander = new Image
            {
                Source = new BitmapImage(new Uri("/Images/rainbow-circle.png", UriKind.RelativeOrAbsolute)),
                Height = 50,
                Width = 50,
                //Stretch = Stretch.None
            };

            Expander expander = new Expander();
            expander.Header = imageExpander;
            expander.Content = expanderPanel;
            expander.Collapsed += Expander_Collapsed;
            stackPanelCode.Children.Add(expander);

        }

        private void ExpanderRB_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            Label label = radioButton.Content as Label;
            SolidColorBrush color = (SolidColorBrush)label.Background;
            getColor = color.Color;
            MessageBox.Show(getColor.ToString());
        }

        private void Expander_Collapsed(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Выбран цвет: "+getColor.ToString());
        }

        private void buttonInButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("ClicK to button in button");
        }

        private void BaseButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("ClicK to base button");
        }

        private void buttonClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void checkBoxState_Checked(object sender, RoutedEventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            checkBox.Content = "Отмечен";
        }

        private void checkBoxState_Unchecked(object sender, RoutedEventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            checkBox.Content = "Не отмечен";
        }

        private void checkBoxState_Indeterminate(object sender, RoutedEventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            checkBox.Content = "Неопределенное состояние";
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            MessageBox.Show(radioButton.Content.ToString());
        }

        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {
            buttonPopur.IsOpen = true;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            textBlockShowEnter.Text = textBox.Text;
        }

        private void buttonSelectedShow_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(textBoxExample.SelectedText);
            textBoxExample.Focus();
        }
    }
}
