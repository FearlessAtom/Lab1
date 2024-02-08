using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
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
namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double a, b, c, D, x1, x2;
            bool error = false;
            if (!double.TryParse(textBox1.Text, out a))
            {
                error = true;
            }
            if (!double.TryParse(textBox2.Text, out b))
            {
                error = true;
            }
            if (!double.TryParse(textBox3.Text, out c))
            {
                error = true;
            }
            if (error)
            {
                MessageBox.Show("Please, enter a valid number!", "Error");
            }
            else
            {
                D = b * b - 4 * a * c;
                if (D == 0)
                {
                    label4.Visibility = System.Windows.Visibility.Visible;
                    textBox5.Visibility = System.Windows.Visibility.Collapsed;
                    label5.Visibility = System.Windows.Visibility.Collapsed;
                    x1 = -b / (2 * a);
                    textBox5.Text = "";
                    textBox4.Text = System.Convert.ToString(x1.ToString("F2"));
                }
                else if (D > 0)
                {
                    label4.Visibility = System.Windows.Visibility.Visible;
                    textBox5.Visibility = System.Windows.Visibility.Visible;
                    label5.Visibility = System.Windows.Visibility.Visible;
                    x1 = (-b + Math.Sqrt(D)) / (2 * a);
                    x2 = (-b - Math.Sqrt(D)) / (2 * a);
                    textBox4.Text = System.Convert.ToString(x1.ToString("F2"));
                    textBox5.Text = System.Convert.ToString(x2.ToString("F2"));
                }
                else 
                {
                    label4.Visibility = System.Windows.Visibility.Collapsed;
                    textBox5.Visibility = System.Windows.Visibility.Collapsed;
                    label5.Visibility = System.Windows.Visibility.Collapsed;
                    textBox4.Text = "No roots";
                }
            }
        }
        private void textBox2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
