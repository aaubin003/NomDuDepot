using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercice_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string mdp;

            Console.WriteLine("Ecrire un mot de passe svp");
            mdp =(Console.ReadLine());
            while(mdp != "mdp")
            {
                Console.WriteLine("Pas bon, ressaisissez un mot de passe");
                mdp=(Console.ReadLine());
            }
            Console.WriteLine("Le mot de passe est correct");
            Console.ReadLine();



        }
    }
}
