using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace min_max_keres
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random szamgen = new Random();
            int[] veletlenszam = new int[10];
            for (int i = 0; i < veletlenszam.Length; i++)
            {
                veletlenszam[i] = szamgen.Next(1, 101);

            }
            foreach (int item in veletlenszam)
            {
                Console.Write($"{item} | ");
            }
            //legkisebb elem kivalasztása
            Console.WriteLine();
            Array.Sort( veletlenszam );
            foreach (int item in veletlenszam)
                {
                    Console.Write($"{item} | ");
                }
            //1. megoldás
            Console.WriteLine($"\nA legkisebb eleme:{veletlenszam[0]}");
            Console.WriteLine($"\nA legnagyobb eleme:{veletlenszam[veletlenszam.Length - 1]}");
            //2. megoldás
            Console.WriteLine($"\nA legkisebb eleme:{veletlenszam.Min()}") ;
            Console.WriteLine($"\nA legnagyobb eleme:{veletlenszam.Max()}") ;
            //3. megoldás

            Console.WriteLine("\nPogram vége");
            Console.ReadLine();
        }
    }
}
