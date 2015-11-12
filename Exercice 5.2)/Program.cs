using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercice_5._2_
{
    class Program
    {
        static void Main(string[] args)
        {
            int i=0;
            int entier;
            Console.WriteLine("Entrer l'entier x souhaité");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Entrer la puissance n souhaitée");
            int n = int.Parse(Console.ReadLine());
            entier = x;

            for(i=1;i<n;i=i+1)
            {
                x=x*entier;
            }
            Console.WriteLine(x);

        }
    }
}
