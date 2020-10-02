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
            // Double til udregning af webshop priser
            double result = 0;
            // Udtager det første cifre af telefonnummer for plads placering
            string cifre = "";
            // Strings til bruger valg
            string valg1 = "";           
            string valg3 = "";
            string valg4 = "";
            string valg5 = "";
            string valg6 = "";

            int talValg1 = 0;
            // Forskelllige int til antal vare bruger vil købe i webshop
            int antalluft = 0;
            int antalsove = 0;
            int antaltelt = 0;

            int i = 0;  // Start værdi til while loop

            string nummer = "tom";  // Personens nummer som string
            int talNummer = 0;  // Personens første cifre af nummer som int
            int pladsNummer = 0;  // Pladsen som personen skal have - Baseret på hvad personens nummer var
            // Til firkant
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
            // Navne til placering i firkant
            string plads1 = "Plads 1";
            string plads2 = "Plads 2";
            string plads3 = "Plads 3";
            string Vareudlevering = "Vareudlevering";


            while (i == 0)  // Pga i == 0 kan while loop starte - Gør også at programmet kan starte forfra når værdi er nul
            {
                i = 1;  // Ændre værdi til 1 så den kan starte det andet while loop

                while (i == 1)  // Pga værdi i == 1 kan den kører
                {
                    Console.WriteLine("Davs, halløj og goddag. Velkommen til Christians Festival!");

                    // Den printer de 4 mugligheder i consolen
                    Console.WriteLine("Du har nu 4 valgmuligheder.\n1. Festivalsplads - Hvor i må slå lejr\n2. Vores webshop hvor du kan købe camping udstyr\n3. Vis kort over festivalen\n4. Aflut programmet");
                    Console.WriteLine();

                    valg1 = Console.ReadLine();  //modtager brugerens svar

                    Console.Clear();

                    // Det her er start menu
                    if (valg1.Length == 1)  // Tjækker for lengden af valg1 string og ser om det er lig med en
                    {
                        try  // Forsøg at konvertere fra input til tal
                        {
                            talValg1 = Convert.ToInt32(valg1);
                        }
                        catch (Exception)  // Hvis det ikke er et tal finder den ud af det og giver inputet som er under
                        {
                            talValg1 = 0;
                            
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("Fejl  Det er ikke et tal");
                            Console.ResetColor();

                            Thread.Sleep(3000);
                            Console.Clear();
                        }
                    }
                    else  // Hvis valg1 string ikke er 1 lang giver den følgene output i stedet
                    {
                        talValg1 = 0;
                        
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("Fejl  Det indtastede nummer er for mange cifre");
                        Console.ResetColor();

                        Thread.Sleep(3000);
                        Console.Clear();
                    }
                    
                    //  Konvertere brugerens valg til en værdi der kan bruges i vores loops
                    if (talValg1 == 1)  // Den giver adgang til pladsuddelling 
                    {
                        i = 2;
                    }
                    else if (talValg1 == 2)  // Den giver adgang til webshop
                    {
                        i = 3;
                    }
                    else if (talValg1 == 3)  // Den giver adgang til kortet
                    {
                        i = 4;
                    }
                    else if (talValg1 == 4)  // Den afslutter programmet
                    {
                        i = 5;
                    }
                }
                // Det her er til pladsuddelling
                while (i == 2)  //  Hvis brugeren har valgt 1 så er i == 2 så kører dette while loop
                {
                    Console.WriteLine("Indtast dit telefon nummer. Udenlansk nummere skal starte med 0");
                    Console.WriteLine();
                    nummer = Console.ReadLine();  // Angiver nummer væredi til brugeres svar

                    Console.WriteLine();

                    cifre = nummer.Substring(0, 1);  // Gemmer den første cifre af brugerens nummer

                    //Console.WriteLine($"Output {cifre}");

                    if (nummer.Length <= 11)  // Hvis brugerens nummer er længere end 11 cifre så vil kører om igen
                    {
                        try  // Hvis den her ikke kan konvertere til int
                        {
                            talNummer = Convert.ToInt32(cifre);
                        }
                        catch (Exception) // Vil den give dette svar og kører den igen
                        {
                            talNummer = 0;

                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("Fejl  Det givende nummer er ikke et tal");
                            Console.ResetColor();

                            Thread.Sleep(3000);
                            Console.Clear();
                        }
                    }
                    else
                    {
                        talNummer = 0;

                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("Fejl  Det givene nummer er over 11 cifre");
                        Console.ResetColor();

                        Thread.Sleep(3000);
                        Console.Clear();
                    }

                    // Giver et pladsnummer baseret på brugerens nummer er
                    if (talNummer >= 1 && talNummer <= 3)
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
                    else
                    {
                        pladsNummer = 0;
                    }

                    if (pladsNummer >= 1 && pladsNummer <= 3)
                    {
                        Console.WriteLine($"Dit plads nummer er {pladsNummer}");  // $ gør at du kan sætte værdier ind i en string

                        // Laver kassens top, bund og midte (vandrette linjer)
                        for (int y = 1; y < brede; y++)
                        {
                            Console.SetCursorPosition(y + startPos, 8);
                            Console.Write(top);

                            Console.SetCursorPosition(y + startPos, 8 + lengde);
                            Console.Write(bund);

                            Console.SetCursorPosition(y + startPos, 8 + lengde / 2);
                            Console.Write(vaMid);
                        }

                        // Laver kassens venstre side, højre side og midte (lodrette linjer)
                        for (int y = 1; y < lengde; y++)
                        {
                            Console.SetCursorPosition(startPos, y + 8);
                            Console.Write(vside);

                            Console.SetCursorPosition(startPos + brede, y + 8);
                            Console.Write(hside);

                            Console.SetCursorPosition(startPos + brede / 2, y + 8);
                            Console.Write(loMid);
                        }

                        // Laver hjørner der får kassen til at se mere fuldendt ud
                        Console.SetCursorPosition(startPos, 8);
                        Console.Write(tvkant);

                        Console.SetCursorPosition(startPos + brede, 8);
                        Console.Write(thkant);

                        Console.SetCursorPosition(startPos, 8 + lengde);
                        Console.Write(bvkant);

                        Console.SetCursorPosition(startPos + brede, 8 + lengde);
                        Console.Write(bhkant);

                        // Laver kryds i midt af kassen for at den ser mere fuldendt ud
                        Console.SetCursorPosition(startPos + brede / 2, 8 + lengde / 2);
                        Console.Write(kryds);

                        // Skriver tekst i felterne basseret på hvad brugerens pladsnummer er
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

                        Console.SetCursorPosition(0, 12 + lengde);  // Sætter curser postion på plads igen

                        Thread.Sleep(5000);
                        Console.Clear();

                        i = 0;
                    }

                }

                // Det her er vores webshop
                while (i == 3) 
                {    // Tekst i begyndelse af webshop                
                    Console.WriteLine("Du har indtastet '2' for vores webshop");

                    Console.WriteLine("---------------Menu---------------");
                    Console.WriteLine("Tryk 1 - for Telt\t tryk 2 - for luftmadras\t tryk 3 - for sovepose\t tryk 4 for at gå tilbage");
                    Console.WriteLine("-----Telt----------350,75kr");
                    Console.WriteLine("-----Luftmadras----255,00kr");
                    Console.WriteLine("-----Sovepose------150,50kr");

                    valg3 = Console.ReadLine(); // Modtager brugers valg i shop

                    switch (valg3) // Start af switch baseret på valget før
                    {
                        case "1": // case til hovedswitch med vareudvalg
                            {
                                Console.WriteLine("Du har valgt Telt - til 350,75kr. Tryk 'Y' hvis du vil købe et telt eller 'N' hvis du fortryder");
                                valg4 = Console.ReadLine().ToUpper(); // Læser brugers svar og gør bogstav til Stort så det er brugbart til næste switch
                                switch (valg4) // Denne switch er til at godkende valgte vare eller ej
                                {
                                    case "Y": // Y hvis købet skal godkendes
                                        {
                                            Console.WriteLine("Vi har godkendt dit køb. Vælg nu antal at telte");

                                            antaltelt = Convert.ToInt32(Console.ReadLine()); // Konverterer string til int så tal kan bruges

                                            Console.Clear();

                                            result = antaltelt * 350.75; // Udregner resultat er totalpris
                                            Console.WriteLine("Du har valgt {0} telte til pris af 350,75kr - totalpris af {1}kr", antaltelt, result);
                                            Console.WriteLine("Du kan hente dine varer her");

                                            // Firkant til afhentning af vare
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
                                    case "N": // Hvis købet skal annulleres
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Dit valg er blevet annulleret");

                                            i = 0;

                                            break;
                                        }
                                }
                                break;
                            }
                        case "2": // case til hovedswitch med vareudvalg
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
                                            Console.Clear();
                                            Console.WriteLine("Dit valg er blevet annulleret");

                                        i = 3;

                                            break;
                                        }
                                }

                                break;
                            }
                        case "3": // case til hovedswitch med vareudvalg
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
                                            Console.Clear();
                                            Console.WriteLine("Dit valg er blevet annulleret");

                                        i = 3;

                                            break;
                                        }

                                }
                                break;
                            }
                        case "4": // case til hovedswitch med vareudvalg
                            {
                                // Den er til hvis bruger vil ud af webshop. Sender tilbage til startskærm
                                i = 0; // bruger start loopet som er i = 0
                                Console.Clear();
                                break;
                            }
                    }
                    


                }
                 // Til kortet ved valg 3 i hovedskærmen
                while (i == 4)
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
                // Til valg 4 i hovedskærmen
                while (i == 5)
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("NYD FESTIVALEN!");
                    Console.ReadKey();
                    Console.ResetColor();
                    Console.Clear();

                    i = 0; // loop sender tilbage til start
                }
            }
            
        }
    }
}