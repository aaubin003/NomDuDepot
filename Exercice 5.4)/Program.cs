using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercice_5._4_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entrer une valeur seuil");
            double seuil = double.Parse(Console.ReadLine());
            Console.WriteLine("Entrer une valeur de x");
            int x=int.Parse(Console.ReadLine());
            double exp=0;
            double s = 0;
            int i=0;
            double condition=1;



            while (condition <= seuil)
           
            {
                    condition = Math.Abs(Math.Pow(x, i + 1) / facto(i + 1));
                    exp =(Math.Pow(x, i)) / facto(i);           
                    s = s + exp;
                    Console.WriteLine("i=" + i + " " + facto(i) + "..." + Math.Pow(x, i) + "  " + s);
                    i = i + 1;
                    
                
            }
            Console.WriteLine(s);



        
    

        }
        public static int facto(int n)
           {
               int i;
               int fact=1;
               for(i=2;i<=n;i=i+1)
               {
                   fact=fact*i;
               }
               return fact;
          
           }
    }
}
