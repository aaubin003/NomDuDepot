using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercice_4_c_
{
    class Program
    {
        static void Main(string[] args)
        {
            string ARRET=".";
            string unCar;
            string phrase="";
            int compteur = 1;  //on commence à 1 car on entre un caractère avant de commencer la boucle while
            Console.WriteLine("Entrer un caractère");
            unCar = Console.ReadLine();
            phrase = phrase + unCar;

            if (unCar == ARRET ||  unCar==" ")
            {
                phrase = "";
                compteur = 0;
            }

            while(unCar != ARRET && compteur<=100)
            {
                Console.WriteLine("Entrer un caractère");
                unCar = Console.ReadLine();

                if (unCar != ARRET && unCar !=" ")
                {
                    phrase = phrase + unCar;
                    compteur = compteur + 1;
                }
            }
      //      phrase = phrase.Substring(0, phrase.Length - 1);     // Substring permet de conserver les caractères compris dans la longueur de chaine spécifiée
            if (compteur <= 100)
            {
                Console.WriteLine("La chaine s'est arrétée car on a rentré" + ARRET);
            }
            else
            {
                Console.WriteLine("La chaine s'est arrétée car on a rentré plus de 100 caractères");
            }

            Console.WriteLine(phrase+"                Le nombre de caractère est :"+compteur);

            Console.ReadLine();



            

        }
    }
}
