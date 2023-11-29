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
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void CompliteButton_Click(object sender, RoutedEventArgs e)
        {
            int n = 0, m = 0;
            string mast = "", dost = "";

            AnswerTextBox.Clear();

            if (string.IsNullOrEmpty(NumberTextBox.Text) || !int.TryParse(NumberTextBox.Text, out n))
            {
                AnswerTextBox.Text += "Введите число\n";
            }
            if (string.IsNullOrEmpty(MastTextBox.Text) || !int.TryParse(MastTextBox.Text, out m))
            {
                AnswerTextBox.Text += "Введите число";
            }
            else
            {
                if (m >= 1 && m <= 4 && n >= 6 && n <= 14)
                {

                    switch (m)
                    {
                        case 1:
                            mast = "пики";
                            break;
                        case 2:
                            mast = "трефы";
                            break;
                        case 3:
                            mast = "бубен";
                            break;
                        case 4:
                            mast = "червей";
                            break;
                    }

                    switch (n)
                    {
                        case 6:
                            dost = "шестерка";
                            break;
                        case 7:
                            dost = "семерка";
                            break;
                        case 8:
                            dost = "восьмерка";
                            break;
                        case 9:
                            dost = "девятка";
                            break;
                        case 10:
                            dost = "десятка";
                            break;
                        case 11:
                            dost = "валет";
                            break;
                        case 12:
                            dost = "дама";
                            break;
                        case 13:
                            dost = "король";
                            break;
                        case 14:
                            dost = "туз";
                            break;

                    }

                    AnswerTextBox.Text += dost + " " + mast;
                }

                else
                {
                    AnswerTextBox.Text += "Такой карты нет";
                }
            }
        }   
    }
}
