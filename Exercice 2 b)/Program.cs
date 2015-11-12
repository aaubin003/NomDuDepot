using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercice_2_b_
{
    class Program
    {
        static void Main(string[] args)
        {
            string mdp;
            int i=1; //on commence à 1 car on entre un mdp avant de lancer le while

            Console.WriteLine("Ecrire un mot de passe svp");
            mdp = (Console.ReadLine());
            
            while (mdp != "mdp" && i<3)
            {
                Console.WriteLine("Pas bon, ressaisissez un mot de passe");
                mdp = (Console.ReadLine());
                i=i+1;
            }
            if (i < 3)
            {
                Console.WriteLine("Le mot de passe est correct");
            }
            else
            {
                Console.WriteLine("Trop d'échecs, vous ne pouvez plus essayer");
            }
            Console.ReadLine();
        }
    }
}
