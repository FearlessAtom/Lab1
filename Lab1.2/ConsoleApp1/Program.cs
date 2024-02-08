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
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)
                                    System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Console.WriteLine("Лабораторна робота 1\nВиконав: Семенчук О.А. IПЗ 23-1\nВарiант 8");
            double a, b, c, x1, x2, D;
            bool converted;
            do
            {
                Console.Write("What is the value of a? : ");
                converted = double.TryParse(Console.ReadLine(), out a);
                if (!converted)
                {
                    Console.WriteLine("Please, enter a valid number!");
                }
            } while (!converted);
            do
            {
                Console.Write("What is the value of b? : ");
                converted = double.TryParse(Console.ReadLine(), out b);
                if (!converted)
                {
                    Console.WriteLine("Please, enter a valid number!");
                }
            } while (!converted);
            do
            {
                Console.Write("What is the value of c? : ");
                converted = double.TryParse(Console.ReadLine(), out c);
                if (!converted)
                {
                    Console.WriteLine("Please, enter a valid number!");
                }
            } while (!converted);
            D = b * b - 4 * a * c;
            if(D == 0)
            {
                x1 = -b / (2 * a);
                Console.WriteLine($"The expression has only one root x = {x1.ToString("F3")}");
            }
            else if(D > 0)
            {
                x1 = (-b + Math.Sqrt(D)) / (2 * a);
                x2 = (-b - Math.Sqrt(D)) / (2 * a);
                Console.WriteLine($"The expressison has two roots x1 = {x1.ToString("F3")}, x2 = {x2.ToString("F3")}");
            }
            else
            {
                Console.WriteLine("The expression has not roots!");
            }
        }
    }
}
