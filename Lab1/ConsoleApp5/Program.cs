using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторна робота а\nВиконав: Семенчук О.А. IПЗ 23-1\nВарiант 8");
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)
                System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            int number, evencount = 0, oddcount = 0, positivecount = 0, negativecount = 0;
            do
            {
                Console.Write(">");
                if (!int.TryParse(Console.ReadLine(), out number))
                {
                    Console.WriteLine("Please, enter a number!");
                }
                else if (number == 0) { break; }
                else
                {
                    if (number % 2 == 0) { evencount++; }
                    else { oddcount++; }
                    if(number > 0) { positivecount++; }
                    else { negativecount++; }
                }
            } while (true);
            Console.WriteLine($"Positive numbers : {positivecount}\nNegative numbers : {negativecount}\nEven numbers : {evencount}\nOdd numbers : {oddcount}");
        }
    }
}
