﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GITHUB_beadas
{
    class Program

    {



        static void Main(string[] args)
        {
            List<int> szamok = new List<int>(10);



            int kapott = 0;
            Console.WriteLine("Adja meg a lsita meretet: ");
            int listameret=(Convert.ToInt32(Console.ReadLine()));
            


            try
            {



                while (kapott != listameret)
                {
                    Console.WriteLine("Adjon meg egy szamot: ");
                    szamok.Add(Convert.ToInt32(Console.ReadLine()));
                    kapott++;

                }


                Console.WriteLine("A legnagyobb szam: " + szamok.Max());
                Console.WriteLine("A legkisebb szam: " + szamok.Min());

            }
            catch (Exception)
            {

                Console.WriteLine("Nem szamot adott meg"); ;
            }

            while (kapott != listameret)
            {
                Console.WriteLine("Adjon meg egy szamot: ");
                szamok.Add(Convert.ToInt32(Console.ReadLine()));
                kapott++;

            }


            Console.WriteLine("A legnagyobb szam: " + szamok.Max());
            Console.WriteLine("A legkisebb szam: " + szamok.Min());


            Console.ReadKey();



        }
    }
}