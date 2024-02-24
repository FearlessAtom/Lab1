using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
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
            int number, k, result = 0;
            bool converted;
            do
            {
                Console.Write("What is the value of n? : ");
                converted = int.TryParse(Console.ReadLine(), out number);
                if (!converted)
                {
                    Console.WriteLine("Please, enter a number!");
                }
            } while (!converted);
            do
            {
                Console.Write("What is the value of k? : ");
                converted = int.TryParse(Console.ReadLine(), out k);
                if (!converted)
                {
                    Console.WriteLine("Please, enter a number!");
                }
            } while (!converted);
            for(int index = 1; index <= number; index++)
            {
                result = result + (int)Math.Pow(index, k);
            }
            Console.WriteLine($"Result = {result}");
        }
    }
}
