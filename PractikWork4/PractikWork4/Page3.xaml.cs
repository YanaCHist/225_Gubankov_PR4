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

namespace PractikWork4
{
    /// <summary>
    /// Логика взаимодействия для Page3.xaml
    /// </summary>
    public partial class Page3 : Page
    {
        public Page3()
        {
            InitializeComponent();
        }

        private void CompliteButton_Click(object sender, RoutedEventArgs e)
        {
            AnswerTextBox.Clear();

            if (string.IsNullOrEmpty(NumberNTextBox.Text) || !int.TryParse(NumberNTextBox.Text, out int n))
            {
                AnswerTextBox.Text += "Введите число";
            }
            else
            {
                while (n > 0 && n % 2 != 1)
                {
                    n /= 10;
                }

                if (n > 0 && n % 2 == 1)
                {
                    AnswerTextBox.Text += "true";
                }
                else
                {
                    AnswerTextBox.Text += "false";
                }
            }
        }
    }
}
