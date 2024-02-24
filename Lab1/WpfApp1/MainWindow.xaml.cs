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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double x, y, z, r;
            bool converted, error = false;
            Console.Write("What is the value of x? : ");
            converted = double.TryParse(textBox1.Text, out x);
            if (!converted)
            {
                error = true;
            }
            converted = double.TryParse(textBox2.Text, out y);
            if (!converted)
            {
                error = true;
            }
            converted = double.TryParse(textBox3.Text, out z);
            if (!converted)
            {
                error = true;
            }
            if (!error)
            {
                double denominator = Math.Sin(x) + Math.Sin(y);
                if (Math.Sin(x) + Math.Sin(y) == 0)
                {
                    MessageBox.Show("Zero division error!", "Error");
                }
                r = (Math.Exp(z + y) * Math.Pow((z - y), x + z)) / denominator + Math.Pow((Math.Pow(x, 7) + Math.Log(y)), 1.0 / 4.0);
                textBox4.Text = r.ToString("F2");
            }
            else
            {
                MessageBox.Show("All the variables have to be valid numbers!", "Error");
            }
        }
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
        }
        private void textBox3_TextChanged(object sender, TextChangedEventArgs e)
        {
        }
        private void textBox2_TextChanged(object sender, TextChangedEventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
