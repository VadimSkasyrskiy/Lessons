using System;
using System.Diagnostics;
using System.Globalization;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());

            switch (a)
            {
                case 1:
                case 2:
                    Console.WriteLine(" ==== 1 or 2");
                    break;
                default:
                    Console.WriteLine("no var");
                    break;
            }
        }
    }
}
