using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercice_5._3_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entrer l'entier n");
            float n = int.Parse(Console.ReadLine());
            double racine = Math.Pow(n, 0.5);

            Console.WriteLine(racine+"   ou   "+(-racine));
        }
    }
}
