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

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            result.IsReadOnly = true;
            day1.MaxLength = 3;
            day2.MaxLength = 3;
            day3.MaxLength = 3;
            day4.MaxLength = 3;
            day5.MaxLength = 3;
            day6.MaxLength = 3;
            day7.MaxLength = 3;

        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (day1.Text.Length <= 3 && day2.Text.Length <= 3 && day3.Text.Length <= 3 && day4.Text.Length <= 3 && day5.Text.Length <= 3 && day6.Text.Length <= 3 && day7.Text.Length <= 3)
            {
                if (day1.Text != "" && day2.Text != "" && day3.Text != "" && day4.Text != "" && day5.Text != "" && day6.Text != "" && day7.Text != "")
                {
                    int dayone = Convert.ToInt32(day1.Text);
                    int daytwo = Convert.ToInt32(day2.Text);
                    int daythree = Convert.ToInt32(day3.Text);
                    int dayfour = Convert.ToInt32(day4.Text);
                    int dayfive = Convert.ToInt32(day5.Text);
                    int daysix = Convert.ToInt32(day6.Text);
                    int dayseven = Convert.ToInt32(day7.Text);

                    if (day1.Text != "0" && day2.Text != "0" && day3.Text != "0" && day4.Text != "0" && day5.Text != "0" && day6.Text != "0" && day7.Text != "0")
                    {
                        double res, count = dayone + daytwo + daythree + dayfour + dayfive + daysix + dayseven;

                        res = count / 7;
                        result.Text = res.ToString();

                    }
                    else
                    {
                        MessageBox.Show("Вес не может быть равен: 0");
                    }
                }
                else
                {
                    MessageBox.Show("Введите корректные данные");
                }
            }
            else
            {
                MessageBox.Show("Введите корректные данные");
            }
        }
        private void day1_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Char.IsDigit(e.Text, 0)) e.Handled = true;
        }

        private void day2_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Char.IsDigit(e.Text, 0)) e.Handled = true;
        }

        private void day3_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Char.IsDigit(e.Text, 0)) e.Handled = true;
        }

        private void day4_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Char.IsDigit(e.Text, 0)) e.Handled = true;
        }

        private void day5_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Char.IsDigit(e.Text, 0)) e.Handled = true;
        }

        private void day6_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Char.IsDigit(e.Text, 0)) e.Handled = true;
        }

        private void day7_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Char.IsDigit(e.Text, 0)) e.Handled = true;
        }
    }
}   
