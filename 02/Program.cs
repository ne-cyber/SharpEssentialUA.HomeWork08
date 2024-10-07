using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    internal class Program
    {
        static class MyPrint
        {
            public static void Print(string stroka, int color)
            {
                if (Enum.IsDefined(typeof(Colors), color))
                    Console.ForegroundColor = (ConsoleColor)(Colors)color;
                else
                    Console.ForegroundColor = ConsoleColor.Gray;

                Console.WriteLine(stroka);
            }
        }

        enum Colors : int
        {
            Gray = ConsoleColor.Gray,
            Default = Gray,
            Red = ConsoleColor.Red,
            Green = ConsoleColor.Green,
            Blue = ConsoleColor.Blue,
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            while (true)
            {
                Console.Write("Ведіть строку: ");
                string str = Console.ReadLine();
                Console.Write("Ведіть колір: ");
                string color = Console.ReadLine();

                //Green = 10

                if (Enum.TryParse(color, out Colors c))
                {
                    if (Enum.IsDefined(typeof(Colors), c))
                        MyPrint.Print(str, (int)c);
                }


                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine(new string('-', 30));
            }


            Console.ReadKey();
        }
    }
}
