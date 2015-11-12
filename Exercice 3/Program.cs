using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercice_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int STOP = 99999;
            int uneVal;
            Console.WriteLine("Entrer un nombre,"+ STOP+"pour finir.");
            uneVal=int.Parse(Console.ReadLine());

            while(uneVal!=STOP)
            {
                if((uneVal>=10)&&(uneVal<100));
                {
                    Console.WriteLine("La valeur"+uneVal+"est un nombre à 2 chiffres.");
                }
                
                    Console.WriteLine("Entrer un autre nombre,"+STOP+"pour finir.");
                    uneVal=int.Parse(Console.ReadLine());
                
            }
            Console.WriteLine("Fin de l'algo");
            Console.ReadLine();
           
               

            
        }
    }
}
