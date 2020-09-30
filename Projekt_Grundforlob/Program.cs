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

            string plads1 = "Plads 1";
            string plads2 = "Plads 2";
            string plads3 = "Plads 3";
            string Vareudlevering = "Vareudlevering";


            while (i == 0)
            {
                Console.WriteLine("Davs, halløj og goddag. Velkommen til Christians Festival!");

                Console.WriteLine("Du har nu 4 valgmuligheder.\n1. Festivalsplads - Hvor i må slå lejr\n2. Vores webshop hvor du kan købe camping udstyr\n3. Vis kort over festivalen\n4. Aflut programmet");
                
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
                else if (talValg1 == 3)
                {
                    i = 3;
                }
                else if (talValg1 == 4)
                {
                    i = 4;
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

                if (pladsNummer == 1)
                {
                    Console.SetCursorPosition(startPos + brede / 4 - svar1.Length / 2, 8 + lengde / 4);
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.Write(svar1);
                    Console.ResetColor();

                    Console.SetCursorPosition(startPos + 3 * (brede / 4) - plads2.Length / 2, 8 + lengde / 4);
                    Console.Write(plads2);

                    Console.SetCursorPosition(startPos + brede / 4 - plads3.Length / 2, 8 + 3 * (lengde / 4));
                    Console.Write(plads3);

                    Console.SetCursorPosition(startPos + 3 * (brede / 4) - Vareudlevering.Length / 2, 8 + 3 * (lengde / 4));
                    Console.Write(Vareudlevering);
                    
                }
                else if (pladsNummer == 2)
                {
                    Console.SetCursorPosition(startPos + brede / 4 - plads1.Length / 2, 8 + lengde / 4);
                    Console.Write(plads1);


                    Console.SetCursorPosition(startPos + 3 * (brede / 4) - svar1.Length / 2, 8 + lengde / 4);
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.Write(svar1);
                    Console.ResetColor();

                    Console.SetCursorPosition(startPos + brede / 4 - plads3.Length / 2, 8 + 3 * (lengde / 4));
                    Console.Write(plads3);

                    Console.SetCursorPosition(startPos + 3 * (brede / 4) - Vareudlevering.Length / 2, 8 + 3 * (lengde / 4));
                    Console.Write(Vareudlevering);
                }
                else
                {
                    Console.SetCursorPosition(startPos + brede / 4 - plads1.Length / 2, 8 + lengde / 4);
                    Console.Write(plads1);

                    
                    Console.SetCursorPosition(startPos + 3 * (brede / 4) - plads2.Length / 2, 8 + lengde / 4);
                    Console.Write(plads2);

                    Console.SetCursorPosition(startPos + brede / 4 - svar1.Length / 2, 8 + 3 * (lengde / 4));
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.Write(svar1);
                    Console.ResetColor();

                    Console.SetCursorPosition(startPos + 3 * (brede / 4) - Vareudlevering.Length / 2, 8 + 3 * (lengde / 4));
                    Console.Write(Vareudlevering);
                }

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

                                        Console.Clear();    

                                        result = antaltelt * 350.75;
                                        Console.WriteLine("Du har valgt {0} telte til pris af 350,75kr - totalpris af {1}kr", antaltelt, result);
                                        Console.WriteLine("Du kan hente dine varer her");

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

                                        Console.SetCursorPosition(startPos + brede / 4 - plads1.Length / 2, 8 + lengde / 4);
                                        Console.Write(plads1);

                                        Console.SetCursorPosition(startPos + 3 * (brede / 4) - plads2.Length / 2, 8 + lengde / 4);
                                        Console.Write(plads2);

                                        Console.SetCursorPosition(startPos + brede / 4 - plads3.Length / 2, 8 + 3 * (lengde / 4));
                                        Console.Write(plads3);

                                        Console.SetCursorPosition(startPos + 3 * (brede / 4) - Vareudlevering.Length / 2, 8 + 3 * (lengde / 4));
                                        Console.BackgroundColor = ConsoleColor.Red;
                                        Console.Write(Vareudlevering);
                                        Console.ResetColor();

                                        Thread.Sleep(5000);
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

                                        Console.Clear();

                                        result = antalluft * 255;

                                        Console.WriteLine("Du har valgt {0} luftmadraser til pris af 255,00kr - totalpris af {1}kr", antalluft, result);

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

                                        Console.SetCursorPosition(startPos + brede / 4 - plads1.Length / 2, 8 + lengde / 4);
                                        Console.Write(plads1);

                                        Console.SetCursorPosition(startPos + 3 * (brede / 4) - plads2.Length / 2, 8 + lengde / 4);
                                        Console.Write(plads2);

                                        Console.SetCursorPosition(startPos + brede / 4 - plads3.Length / 2, 8 + 3 * (lengde / 4));
                                        Console.Write(plads3);

                                        Console.SetCursorPosition(startPos + 3 * (brede / 4) - Vareudlevering.Length / 2, 8 + 3 * (lengde / 4));
                                        Console.BackgroundColor = ConsoleColor.Red;
                                        Console.Write(Vareudlevering);
                                        Console.ResetColor();

                                        Thread.Sleep(5000);
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

                                        Console.Clear();

                                        result = antalsove * 150.50;

                                        Console.WriteLine("Du har valgt {0} soveposer til pris af 255,00kr - totalpris af {1}kr", antalsove, result);

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

                                        Console.SetCursorPosition(startPos + brede / 4 - plads1.Length / 2, 8 + lengde / 4);
                                        Console.Write(plads1);

                                        Console.SetCursorPosition(startPos + 3 * (brede / 4) - plads2.Length / 2, 8 + lengde / 4);
                                        Console.Write(plads2);

                                        Console.SetCursorPosition(startPos + brede / 4 - plads3.Length / 2, 8 + 3 * (lengde / 4));
                                        Console.Write(plads3);

                                        Console.SetCursorPosition(startPos + 3 * (brede / 4) - Vareudlevering.Length / 2, 8 + 3 * (lengde / 4));
                                        Console.BackgroundColor = ConsoleColor.Red;
                                        Console.Write(Vareudlevering);
                                        Console.ResetColor();

                                        Thread.Sleep(5000);
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
            
            while (i == 3)
            {
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

                Console.SetCursorPosition(startPos + brede / 4 - plads1.Length / 2, 8 + lengde / 4);
                Console.Write(plads1);

                Console.SetCursorPosition(startPos + 3 * (brede / 4) - plads2.Length / 2, 8 + lengde / 4);
                Console.Write(plads2);

                Console.SetCursorPosition(startPos + brede / 4 - plads3.Length / 2, 8 + 3 * (lengde / 4));
                Console.Write(plads3);

                Console.SetCursorPosition(startPos + 3 * (brede / 4) - Vareudlevering.Length / 2, 8 + 3 * (lengde / 4));
                Console.Write(Vareudlevering);

                Thread.Sleep(5000);
                Console.Clear();

                i = 0;

            }

            while (i == 4)
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("NYD FESTIVALEN!");
                Console.ReadKey();

                return;
            }


        }
    }
}


