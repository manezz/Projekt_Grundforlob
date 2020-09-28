using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace fix1
{
    class Program
    {
        static void Main(string[] args)
        {           
            double result = 0;

            string cifre = "";

            string valg1 = "";
            string valg2 = "";
            string valg3 = "";
            string valg4 = "";
            string valg5 = "";
            string valg6 = "";

            //int plads1 = 0, 12 + lengde;
            

            int talValg1 = 0;

            int antalluft = 0;
            int antalsove = 0;
            int antaltelt = 0;

            int i = 0;

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

            int startPos = 30;

            int brede = 80;
            int lengde = 20;

            string svar1 = "Her skal du slaa lejer";


            while (i == 0)
            {
                Console.WriteLine("Davs, halløj og goddag. Velkommen til Christians Festival!");

                Console.WriteLine("Du har nu to valgmuligheder.\n1. Festivalsplads - Hvor i må slå lejr\n2. Vores webshop hvor du kan købe camping udstyr");
                
                valg1 = Console.ReadLine();  //modtager brugerens svar

                if (valg1.Length == 1) // Det her er start menu
                {
                    try 
                    {
                        talValg1 = Convert.ToInt32(valg1);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Det er ikke et tal");
                    }
                }
                else
                {
                    Console.WriteLine("Det indtastede nummer er for mange cifre");
                }

                if (talValg1 == 1)
                {
                    i = 1;
                }
                else if (talValg1 == 2)
                {
                    i = 2;
                }
                else
                {
                    Console.WriteLine("Det er ikke et acceptabelt valg");
                }
            }

            while (i == 1) // Det her er til brugerens plads
            {
                Console.WriteLine("Indtast dit telefon nummer. Udenlansk nummere skal starte med 0");
                nummer = Console.ReadLine();
                
                cifre = nummer.Substring(0, 1);

                Console.WriteLine($"Output {cifre}");               

                if (nummer.Length <= 11)
                {
                    try 
                    {
                        talNummer = Convert.ToInt32(cifre);
                        i = 0;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Det givende nummer er over 11 cifre. Prøv igen");
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
                    Console.SetCursorPosition(y + startPos, 8);
                    Console.Write(top);

                    Console.SetCursorPosition(y + startPos, 8 + lengde);
                    Console.Write(bund);

                    Console.SetCursorPosition(y + startPos, 8 + lengde / 2);
                    Console.Write(vaMid);
                }

                for (int y = 1; y < lengde; y++)
                {
                    Console.SetCursorPosition(startPos, y + 8);
                    Console.Write(vside);

                    Console.SetCursorPosition(startPos + brede, y + 8);
                    Console.Write(hside);

                    Console.SetCursorPosition(startPos + brede / 2, y + 8);
                    Console.Write(loMid);
                }

                Console.SetCursorPosition(startPos, 8);
                Console.Write(tvkant);

                Console.SetCursorPosition(startPos + brede, 8);
                Console.Write(thkant);

                Console.SetCursorPosition(startPos, 8 + lengde);
                Console.Write(bvkant);

                Console.SetCursorPosition(startPos + brede, 8 + lengde);
                Console.Write(bhkant);

                Console.SetCursorPosition(startPos + brede / 2, 8 + lengde / 2);
                Console.Write(kryds);

                Console.SetCursorPosition(startPos + brede / 4 - svar1.Length / 2, 8 + lengde / 4 );
                Console.Write(svar1);

                Console.SetCursorPosition(0, 12 + lengde);
            }

                while (i == 2)  // Det her er vores webshop
                {
                  
                    Console.WriteLine("Du har indtastet '2' for vores webshop");
                    
                    Console.WriteLine("---------------Menu---------------");
                    Console.WriteLine("Tryk 1 - for Telt\t tryk 2 - for luftmadras\t tryk 3 - for sovepose");
                    Console.WriteLine("-----Telt----------350,75kr");
                    Console.WriteLine("-----Luftmadras----255,00kr");
                    Console.WriteLine("-----Sovepose------150,50kr");

                    valg3 = Console.ReadLine();

                    switch (valg3)
                    {
                        case "1":
                            {
                                Console.WriteLine("Du har valgt Telt - til 350,75kr. Tryk 'Y' hvis du vil købe et telt eller 'N' hvis du fortryder");
                                valg4 = Console.ReadLine().ToUpper();
                                switch (valg4) 
                                {
                                    case "Y":
                                        {
                                            Console.WriteLine("Vi har godkendt dit køb. Vælg nu antal at telte");

                                            antaltelt = Convert.ToInt32(Console.ReadLine());                                                  
                                            result = antaltelt * 350.75;
                                            Console.WriteLine("Du har valgt {0} telte til pris af 350,75kr - totalpris af {1}kr", antaltelt, result);
                                            Thread.Sleep(3000);
                                            Console.Clear();
                                        break;
                                        }
                                    case "N":
                                        {
                                            Console.WriteLine("Dit valg er blevet annulleret");

                                            break;
                                        }
                                }
                                break;
                            }
                        case "2":
                            {
                                Console.WriteLine("Du har valgt luftmadras - til 255,00kr. Tryk 'Y' hvis du vil købe et telt eller 'N' hvis du fortryder");

                                valg5 = Console.ReadLine().ToUpper();

                                switch (valg5)
                                {
                                    case "Y":
                                        {
                                            Console.WriteLine("Vi har godkendt dit køb. Vælg nu antal at luftmadraser");

                                            antalluft = Convert.ToInt32(Console.ReadLine());
                                            result = antalluft * 255;

                                            Console.WriteLine("Du har valgt {0} luftmadraser til pris af 255,00kr - totalpris af {1}kr", antalluft, result);
                                            Thread.Sleep(3000);
                                        Console.Clear();
                                        break;
                                        }
                                    case "N":
                                        {
                                            Console.WriteLine("Dit valg er blevet annulleret");

                                            break;
                                        }
                                }
                                    
                            break;
                            }
                        case "3":
                            {
                                Console.WriteLine("Du har valgt sovepose - til 150,50kr. Tryk 'Y' hvis du vil købe et telt eller 'N' hvis du fortryder");

                                valg6 = Console.ReadLine().ToUpper();

                                switch (valg6)
                                {
                                    case "Y":
                                        {
                                            Console.WriteLine("Vi har godkendt dit køb. Vælg nu antal at soveposer");

                                            antalsove = Convert.ToInt32(Console.ReadLine());
                                            result = antalsove * 150.50;

                                            Console.WriteLine("Du har valgt {0} soveposer til pris af 255,00kr - totalpris af {1}kr", antalsove, result);
                                            Thread.Sleep(3000);
                                            Console.Clear();
                                            break;
                                        }
                                    case "N":
                                        {
                                            Console.WriteLine("Dit valg er blevet annulleret");

                                            break;
                                        }
                                }
                                break;                            
                            }     
                    }
                }
            Console.ReadKey();
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("NYD FESTIVALEN!");
            Console.ReadKey();
        }
    }
}


