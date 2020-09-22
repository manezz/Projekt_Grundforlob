using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Grundforlob
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;

            string nummer = "tom";

            int talNummer = 0;

            int pladsNummer = 0;

            while (i == 1) 
            {
                Console.WriteLine("Skriv første cifre af dit tellefon nummer");

                nummer = Console.ReadLine();

                if (nummer.Length == 1)
                {
                    try 
                    {
                        talNummer = Convert.ToInt32(nummer);
                        i = 0;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Det er ikke et tal");
                    }
                }
                else
                {
                    Console.WriteLine("Det er ikke kun en cifre");
                }

            }

            if (talNummer >= 0 && talNummer <= 3)
            {
                pladsNummer = 1;
            }
            else if (talNummer >= 4 && talNummer <= 6)
            {
                pladsNummer = 2;
            }
            else if (talNummer >= 7 && talNummer <= 9)
            {
                pladsNummer = 3;
            }

            Console.WriteLine($"Dit plads nummer er {pladsNummer}");


            
            Console.WriteLine("Tryk på en vilkårlig tast for at afslutte");
            Console.ReadLine();
        }
    }
}
