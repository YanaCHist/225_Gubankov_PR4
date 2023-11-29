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
using static System.Math;

namespace PractikWork4
{
    /// <summary>
    /// Логика взаимодействия для Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        public Page2()
        {
            InitializeComponent();
        }

        private void CompliteButton_Click(object sender, RoutedEventArgs e)
        {
            AnswerTextBox.Clear();

            int n, k = 0;

            if (string.IsNullOrEmpty(NumberNTextBox.Text) || !int.TryParse(NumberNTextBox.Text, out n))
            {
                AnswerTextBox.Text += "Введите число";
            }
            else
            {
                if (n > 0)
                {
                    while (Pow(2, k) < n)
                    {
                        k++;
                    }

                    AnswerTextBox.Text += $"{k}";
                }
                else
                {
                    AnswerTextBox.Text += "Введите положительное число больше 0";
                }
            }
        }
    }
}
