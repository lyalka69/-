using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Console;

namespace praktikum15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Title = "Пракикум 15 - Вячеслава Симаченко";

            //var1
            Console.WriteLine("Var1");
            for ( double x = -1 ; x <= 1; x+= 0.1) 
            {
                Console.WriteLine($"1x = {x:f2}  f(x) = {3 * Math.Pow(x , 2):f2}");
            }
            Console.ReadKey();
            //var2
            Console.WriteLine("Var2");
            for (double x = -2; x <= 2; x += 0.2)
            {
                Console.WriteLine($"x = {x:f2}  f(x) = {Math.Pow(x, 3):f2}");
            }
            Console.ReadKey();
            //var3
            Console.WriteLine("Var3");
            for (double x = 0; x <= 5; x += 0.2)
            {
                Console.WriteLine($"x = {x:f2}  f(x) = {Math.Sqrt(x):f2}");
            }
            Console.ReadKey();
            //var4
            Console.WriteLine("Var4");
            for (double x = -3.14; x <= 3.14; x += 0.2)
            {
                Console.WriteLine($"x = {x:f2}  f(x) = {Math.Cos(x):f2}");
            }
            Console.ReadKey();
            //var5
            Console.WriteLine("Var5");
            for (double x = 1; x <= 12; x += 0.5)
            {
                Console.WriteLine($"x = {x:f2}  f(x) = {12 / x:f2}");
            }
            Console.ReadKey();
            //var6
            Console.WriteLine("Var6");
            for (double x = -1.57; x <= 1.57; x += 0.2)
            {
                Console.WriteLine($"x = {x:f2}  f(x) = {Math.Tan(x):f2}");
            }
            Console.ReadKey();
            //var7
            Console.WriteLine("Var7");
            for (double x = 0; x <= 2; x += 0.2)
            {
                Console.WriteLine($"x = {x:f2}  f(x) = {Math.Sqrt(x) / x + 1:f2}");
            }
            Console.ReadKey();
            //var8
            Console.WriteLine("Var8");
            for (double x = -3.14; x <= 3.14; x += 0.2)
            {
                Console.WriteLine($"x = {x:f2}  f(x) = {Math.Sin(x):f2}");
            }
            Console.ReadKey();
            //var9
            Console.WriteLine("Var9");
            for (double x = -3; x <= 3; x += 0.5)
            {
                Console.WriteLine($"x = {x:f2}  f(x) = {0.5 * x:f2}");
            }
            Console.ReadKey();
            //var10
            Console.WriteLine("Var10");
            for (double x = 0; x <= 8; x += 0.2)
            {
                Console.WriteLine($"x = {x:f2}  f(x) = {0.5 * Math.Pow((x - 5), 2):f2}");
            }
            Console.ReadKey();
            //var11
            Console.WriteLine("Var11");
            for (double x = -5; x <= 5; x += 0.2)
            {
                Console.WriteLine($"x = {x:f2}  f(x) = {0.25 * Math.Pow(x,2) + x + 1:f2}");
            }
            Console.ReadKey();
            //var12
            Console.WriteLine("Var12");
            for (double x = -2; x <= 7; x += 0.1)
            {
                Console.WriteLine($"x = {x:f2}  f(x) = {0.5 * Math.Pow((x - 3), 2) + 2:f2}");
            }
            Console.ReadKey();
            //var13
            Console.WriteLine("Var13");
            for (double x = -3; x <= 3; x += 0.2)
            {
                Console.WriteLine($"x = {x:f2}  f(x) = {Math.Abs(x)}");
            }
            Console.ReadKey();
            //var14
            Console.WriteLine("Var14");
            for (double x = -3; x <= 3; x += 0.1)
            {
                Console.WriteLine($"x = {x:f2}  f(x) = {0.125 * Math.Pow(x , 4) - Math.Pow(x , 2):f2}");
            }
            Console.ReadKey();
        }
    }
}
