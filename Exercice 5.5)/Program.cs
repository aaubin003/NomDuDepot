using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercice_5._5_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entrer la taille souhaitée du tableau");
            int taille=int.Parse(Console.ReadLine());
            float[] tab = new float[taille];
            int i=0;
            Random r = new Random();
            

            Console.WriteLine("Le tableau de base est le suivant :");
            for (int j = 0; j < taille; j = j + 1)
            {
                float nb = r.Next(0, 100);
                tab[j] = nb;
                
                Console.WriteLine(tab[j]);
            }
            Console.WriteLine("Entrer le nombre que vous voulez mettre");
            float x=float.Parse(Console.ReadLine());
            Console.WriteLine("Entrer l'emplacement souhaité");
            int k = int.Parse(Console.ReadLine());

            for(i=taille-2;i>k+1;i=i-1)//on part de la dernière case 
            {
                tab[i + 1] = tab[i];
                if(i==k+1)
                {

            }
           
                
            }
            Console.WriteLine("Le tableau final est le suivant :");
            for (i = 0; i < taille; i = i + 1)
            {
                
                Console.WriteLine(tab[i]);
            }

                


            
 



        }
    }
}
