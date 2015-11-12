using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercice_4
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int fact=1;
            int Val;
            int i;
            Console.WriteLine("Entrer un nombre entier");
            Val = int.Parse(Console.ReadLine());
            for (i=2; i <= Val; i = i + 1) 
            {
                fact= fact * i;
               
            }
            Console.WriteLine("Le factoriel de votre nombre est :"+fact);//on commence à 2 car pour val= 0 et 1 fact=1 et ca sert a rien de multiplier par 1)
            Console.ReadLine();




        }
    }
}
