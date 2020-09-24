using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fix1
{
    class Program
    {
        static void Main(string[] args)
        {
            double result;

            {
                Console.WriteLine("Davs, halløj og goddag. Velkommen til Christians Festival!");
                Console.WriteLine("Du har nu to valgmuligheder.\n1. Festivalsplads - Hvor i må slå lejr\n2. Vores webshop hvor du kan købe camping udstyr");
                string valg1;//Skaber en string for at modtager bruger svar
                valg1 = Console.ReadLine();//modtager brugerens svar
                switch (valg1)//udnytte brugerens svar til vores switch
                {
                    case "1"://case for festivalsplads
                        {
                            Console.WriteLine("Du har valgt 'Festivalsplads'\tindtast det første cifre i dit telefon nummer for at blive tildelt en teltplads");
                            Console.WriteLine("Hvis dit nummer er udenlandsk så indtast '0'");
                            string valg2;
                            valg2 = Console.ReadLine();
                            switch (valg2)
                            {
                                case "0":// Ikke indgået i opgaven men udenlandske nummere indtastes med 0
                                case "1":
                                case "2"://flere cases giver samme resutalt før break
                                case "3":
                                    {
                                        Console.WriteLine("Dit telefon nummer starter med 0, 1, 2 eller 3");
                                        break;
                                    }
                                case "4":
                                case "5":
                                case "6":
                                    {
                                        Console.WriteLine("Dit telefon nummer starter med 4, 5 eller 6");
                                        break;
                                    }
                                case "7":
                                case "8":
                                case "9":
                                    {
                                        Console.WriteLine("Dit telefon nummer starter med 7, 8 eller 9");
                                        break;
                                    }

                            }
                            break;
                        }

                    case "2"://case for webshop
                        {
                            Console.WriteLine("Du har indtastet '2' for vores webshop");
                            Console.WriteLine("---------------Menu---------------");
                            Console.WriteLine("Tryk 1 - for Telt\t tryk 2 - for luftmadras\t tryk 3 - for sovepose");
                            Console.WriteLine("\t\t\t-----Telt----------350,75 kr");
                            Console.WriteLine("\t\t\t-----Luftmadras----255,00 kr");
                            Console.WriteLine("\t\t\t-----Sovepose------150,50 kr");
                            string valg3;
                            valg3 = Console.ReadLine();
                            switch (valg3)
                            {
                                case "1"://case 1 til webshop
                                    {
                                        string valg4;
                                        Console.WriteLine("Du har valgt Telt - til 350,75 kr. Tryk 'Y' hvis du vil købe et telt eller 'N' hvis du fortryder");
                                        valg4 = (Console.ReadLine().ToUpper());

                                        switch (valg4)
                                        {
                                            case "Y"://bruger skal bekræfte at de vil købe telte
                                                {
                                                    Console.WriteLine("Vi har godkendt dit køb. Vælg nu antal at telte");
                                                    int antaltelt;//oprette int til bruger input af antal telte
                                                    antaltelt = Convert.ToInt32(Console.ReadLine());//converter til tal
                                                    result = antaltelt * 350.75;//ganger antal telte med pris for at give total pris
                                                    Console.WriteLine("Du har valgt {0} telte til pris af 350,75 kr - totalpris af {1} kr", antaltelt, result);
                                                    break;// alle trin gentages til 3 indkøbs valgmuligheder
                                                }
                                            case "N"://hvis bruger fortryder
                                                {
                                                    Console.WriteLine("Dit valg er blevet annulleret");
                                                    break;
                                                }
                                        }
                                        break;
                                    }
                                case "2"://case 2 til webshop
                                    {
                                        Console.WriteLine("Du har valgt luftmadras - til 255,00 kr. Tryk 'Y' hvis du vil købe et telt eller 'N' hvis du fortryder");
                                        string valg5;
                                        valg5 = (Console.ReadLine().ToUpper());
                                        switch (valg5)
                                        {
                                            case "Y":
                                                {
                                                    Console.WriteLine("Vi har godkendt dit køb. Vælg nu antal at luftmadraser");
                                                    int antalluft = 0;
                                                    antalluft = Convert.ToInt32(Console.ReadLine());
                                                    result = antalluft * 255;
                                                    Console.WriteLine("Du har valgt {0} luftmadraser til pris af 255,00 kr - totalpris af {1} kr", antalluft, result);
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
                                case "3"://case 3 til webshop
                                    {
                                        Console.WriteLine("Du har valgt sovepose - til 150,50 kr. Tryk 'Y' hvis du vil købe et telt eller 'N' hvis du fortryder");
                                        string valg6;
                                        valg6 = (Console.ReadLine().ToUpper());
                                        switch (valg6)
                                        {
                                            case "Y":
                                                {
                                                    Console.WriteLine("Vi har godkendt dit køb. Vælg nu antal at soveposer");
                                                    int antalsove;
                                                    antalsove = Convert.ToInt32(Console.ReadLine());
                                                    result = antalsove * 150.50;
                                                    Console.WriteLine("Du har valgt {0} soveposer til pris af 255,00 kr - totalpris af {1} kr", antalsove, result);
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
                        break;
                }
            }
            Console.WriteLine("Tryk 'ENTER' for at lukke");
            Console.ReadKey();
        }
    }
}
