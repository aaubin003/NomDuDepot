using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercice_5._1_
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;//compteur
            int somme = 0;
            Console.WriteLine("Entrer un réel n, dernier terme de votre somme");
            int n = int.Parse( Console.ReadLine());

            for (i = 0; i <= n; i = i + 1)
            {
                somme = somme + i;
            }

            Console.WriteLine(somme);





        }
    }
}
