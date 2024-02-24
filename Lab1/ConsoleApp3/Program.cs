using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
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
            int number, result = 0;
            bool converted;
            do
            {
                Console.Write(">");
                converted = int.TryParse(Console.ReadLine(), out number);
                if (!converted)
                {
                    Console.WriteLine("Please, enter a number!");
                }
            }while (!converted);
            for(int index = 0; index < number; index++)
            {
                result = result + (int)Math.Pow((index + 1), number - index);
            }
            Console.WriteLine($"Result = {result}");
        }
    }
}
