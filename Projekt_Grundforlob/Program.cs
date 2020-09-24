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

            string tvkant = "\x250C";
            string thkant = "\x2510";
            string bvkant = "\x2514";
            string bhkant = "\x2518";

            string vside = "\x2502";
            string hside = "\x2502";
            string top = "\x2500";
            string bund = "\x2500";

            string vaMid = "\x2500";
            string loMid = "\x2502";

            string kryds = "\x253C";

            int brede = 80;
            int lengde = 20;
            //int startPos = 0;


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

            for (int y = 1; y < brede; y++)
            {
                Console.SetCursorPosition(y + 30, 8);
                Console.Write(top);

                Console.SetCursorPosition(y + 30, 8 + lengde);
                Console.Write(bund);

                Console.SetCursorPosition(y + 30, 8 + lengde / 2);
                Console.Write(vaMid);
            }

            for (int y = 1; y < lengde; y++)
            {
                Console.SetCursorPosition(30, y + 8);
                Console.Write(vside);

                Console.SetCursorPosition(30 + brede, y + 8);
                Console.Write(hside);

                Console.SetCursorPosition(30 + brede / 2, y + 8);
                Console.Write(loMid);
            }

            Console.SetCursorPosition(30, 8);
            Console.Write(tvkant);

            Console.SetCursorPosition(30 + brede, 8);
            Console.Write(thkant);

            Console.SetCursorPosition(30, 8 + lengde);
            Console.Write(bvkant);

            Console.SetCursorPosition(30 + brede, 8 + lengde);
            Console.Write(bhkant);

            Console.SetCursorPosition(30 + brede / 2, 8 + lengde / 2);
            Console.Write(kryds);

            //Console.SetCursorPosition()
            

            Console.SetCursorPosition(0, 12 + lengde);

            Console.WriteLine("");
            Console.WriteLine("Tryk på en vilkårlig tast for at afslutte");
            Console.ReadLine();
        }
    }
}
