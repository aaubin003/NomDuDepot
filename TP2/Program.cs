using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TP2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 10;
            int x = 0;
            int s=0;
            a = 2 * a + b;
            b = b - a;
            while (x < 5) { 
                a = x * b; 
                b = a - b; 
                x = x + 2; 
            }
            s = a + b;
            Console.WriteLine("s=" + s);
            Console.ReadLine();



        }
    }
}
