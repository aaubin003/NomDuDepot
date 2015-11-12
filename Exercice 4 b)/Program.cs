using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercice_4_b_
{
    class Program
    {
        static void Main(string[] args)
        {
            int reponse;
            Console.WriteLine("Si vous êtes une étudiante taper 1, sinon taper 2");
            reponse = int.Parse(Console.ReadLine());

            while (reponse != 1 && reponse != 2)
            {
                Console.WriteLine("Si vous êtes une étudiante taper 1, sinon taper 2");
                reponse = int.Parse(Console.ReadLine());
            }

           
            if (reponse == 1)
            {
                Console.WriteLine("Bonjour Mademoiselle");
            }
            else
            {
                Console.WriteLine("Bonjour Monsieur");
            }
            Console.ReadLine();

        }
    }
}
