using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sallai_martin_ywusm7_211001
{
    class Program
    {
        static void Main(string[] args)
        {
            //*
            //   szamsor();
            //   bekeres();
            //   veletlen();
            //   izehoze();
            //   izehoze();
            //   kockadobas();
            //   valosszamok();
            haromszog();

            Console.ReadKey();
        }
        static void szamsor()
        {   // start
            Console.WriteLine("megadott szamsor kiiratás");
            for (int i = 6; i <= 30; i += 3)
            {

                Console.Write("{0} ", (-1 * i));

            }
            Console.WriteLine();

        }  // stop
        static void izehoze()
        {
            // Console.WriteLine("3al osztható számok 100ig");
            //  for (int i = 3; i <= 100; i = 3; i+=3)
            //  {
            //  /     
            //  }
        }
        static void bekeres()
        {
            string be;

            int count = 0;

            int szam = 0;

            int ossz = 0;


            Console.WriteLine("Adat bekérés 0 végjelig. \n");

            while ((be = Console.ReadLine())!="0")
            {
                count++;
                szam = Convert.ToInt32(be);
                szam = ossz + szam;

            }
            Console.WriteLine(" Összeg: " + ossz + " Darabszám " + count );     
            
        }
        static void veletlen ()
        {   //start
            Console.WriteLine("Ötös lottó");
            Random rnd = new Random();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(rnd.Next(1,91) + " " );
            }

        } //end
        static void kockadobas ()
        {
            Console.WriteLine("\n\tKockadobás\n\t");
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(rnd.Next(1,7) + "  " );
            }
        }
        static void valosszamok()
        {





        }
        static void haromszog()
        {
            Console.WriteLine("Haromszog");
            
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; i < 10; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
