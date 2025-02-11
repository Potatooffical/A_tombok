using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feladat_jegyzet_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random szamgen = new Random();
            int[] veletlenszam = new int[10];
            for (int i = 0; i < veletlenszam.Length; i++)
            {
                veletlenszam[i] = szamgen.Next(1,101);
                
            }
            foreach (int item in veletlenszam)
                {
                    Console.Write($"{item} | ");
                }
            Console.WriteLine("Pogram vége");
            Console.ReadLine();
        }
    }
}
