using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)
                        System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click_1(object sender, EventArgs e)
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
                    MessageBox.Show("Zero division error!","Error");
                }
                r = (Math.Exp(z + y) * Math.Pow((z - y), x + z)) / denominator + Math.Pow((Math.Pow(x, 7) + Math.Log(y)), 1.0 / 4.0);
                textBox4.Text = r.ToString("F2");
            }
            else
            {
                MessageBox.Show("All the variables have to be valid numbers!", "Error");
            }
        }
    }
}
