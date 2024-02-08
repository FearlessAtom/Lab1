using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)
                                                System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
        }

        private void button1_Click(object sender, EventArgs e)
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
                if(D == 0)
                {
                    x1 = -b / (2 * a);
                    label5.Visible = false;
                    textBox5.Visible = false;
                    label4.Text = "x = ";
                    textBox4.Visible = true;
                    textBox4.Text = System.Convert.ToString(x1.ToString("F2"));
                }
                else if(D > 0)
                {
                    label4.Text = "x1 =";
                    label5.Visible = true;
                    textBox4.Visible = true;
                    textBox5.Visible = true;
                    x1 = (-b + Math.Sqrt(D)) / (2 * a);
                    x2 = (-b - Math.Sqrt(D)) / (2 * a);
                    textBox4.Text = System.Convert.ToString(x1.ToString("F2"));
                    textBox5.Text = System.Convert.ToString(x2.ToString("F2"));
                }
                else
                {
                    label4.Text = "No roots";
                    label5.Visible = false;
                    textBox4.Visible = false;
                    textBox5.Visible = false;
                }
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
        private void label5_Click(object sender, EventArgs e)
        {
        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
        }
        private void label4_Click(object sender, EventArgs e)
        {
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
