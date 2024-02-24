using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторна робота 1\nВиконав: Семенчук О.А. IПЗ 23-1\nВарiант 8");
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)
                                    System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            double x, y, z, r;
            bool converted;
            do
            {
                Console.Write("What is the value of x? : ");
                converted = double.TryParse(Console.ReadLine(), out x);
                if (!converted)
                {
                    Console.WriteLine("Please, enter a number!");
                }
            } while (!converted);
            do
            {
                Console.Write("What is the value of y? : ");
                converted = double.TryParse(Console.ReadLine(), out y);
                if (!converted)
                {
                    Console.WriteLine("Please, enter a number!");
                }
            } while (!converted);
            do
            {
                Console.Write("What is the value of z? : ");
                converted = double.TryParse(Console.ReadLine(), out z);
                if (!converted)
                {
                    Console.WriteLine("Please, enter a number!");
                }
            } while (!converted);
            double denominator = Math.Sin(x) + Math.Sin(y);
            if (Math.Sin(x) + Math.Sin(y) == 0)
            {
                Console.WriteLine("Zero division error!");
            }
            else
            {
                r = (Math.Exp(z + y) * Math.Pow((z - y), x + z)) / denominator + Math.Pow((Math.Pow(x, 7) + Math.Log(y)), 1.0 / 4.0);
                Console.WriteLine(r.ToString("F3"));
            }
        }
    }
}
