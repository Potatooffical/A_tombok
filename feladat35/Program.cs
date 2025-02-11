using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace feladat35
{
    internal class Program
    {
        static void Main(string[] args)
        {/*Feltölt egy 10 elemű tömböt 1 és 100 közötti egészekkel és kiírja az átlagot meghaladó
            értékeket.*/

            Random rnd = new Random();
            var szamok = new int[10];
            double osszeg = 0;
            //elemek feltoltese
            for (int i = 0; i < szamok.Length; i++)
            {
                szamok[i] = rnd.Next(1, 101);
                osszeg = osszeg + szamok[i];
            }
            //elemek kiiraatasa
            for (int i = 0; i < szamok.Length; i++)
            {
                Console.Write(szamok[i] + " | ");

            }
            Console.Write($"A tömb elemeinek összege:{osszeg}");
            double atlag = osszeg / szamok.Length;
            Console.WriteLine("Az elemekek átlaga" + atlag ;
            foreach (int elem in szamok)
            {
                if (elem > atlag)
                {
                    Console.WriteLine(elem);
                }
            }
            Console.ReadKey();
        }
    }
}