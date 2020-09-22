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
                Console.WriteLine("I har nu to valgmuligheder.\n1. Festivalsplads - Hvor i må slå lejr\n2. Vores webshop hvor du kan købe camping udstyr");
                string valg1;//Skaber en string for at modtager bruger svar
                valg1 = Console.ReadLine();//modtager brugerens svar
                switch (valg1)//udnytte brugerens svar til vores switch
                {
                    case "1"://case for festivalsplads
                        {
                            Console.WriteLine("Du har valgt 'Festivalsplads'\tindtast det første cifre i dit telefon nummer for at blive tildelt en teltplads");
                            string valg2;
                            valg2 = Console.ReadLine();
                            switch (valg2)
                            {
                                case "0":// Ikke indgået i opgaven men vi er så flinke her i gruppe 1 at telefonnummere med 0 må godt være med til vores festival
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

                    case "2":
                        {
                            Console.WriteLine("Du har indtastet '2' for vores webshop");
                            Console.WriteLine("---------------Menu---------------");
                            Console.WriteLine("Tryk 1 - for Telt\t tryk 2 - for luftmadras\t tryk 3 - for sovepose");
                            Console.WriteLine("-----Telt----------350,75kr");
                            Console.WriteLine("-----Luftmadras----255,00kr");
                            Console.WriteLine("-----Sovepose------150,50kr");
                            string valg3;
                            valg3 = Console.ReadLine();
                            switch (valg3)
                            {
                                case "1":
                                    {
                                        string valg4;
                                        Console.WriteLine("Du har valgt Telt - til 350,75kr. Tryk 'Y' hvis du vil købe et telt eller 'N' hvis du fortryder");
                                        valg4 = Console.ReadLine();
                                        switch (valg4) 
                                        {
                                            case "Y":
                                                {
                                                    Console.WriteLine("Vi har godkendt dit køb. Vælg nu antal at telte");
                                                    int antaltelt;
                                                    antaltelt = Convert.ToInt32(Console.ReadLine());                                                  
                                                    result = antaltelt * 350.75;
                                                    Console.WriteLine("Du har valgt[0] telte til pris af 350,75kr - totalpris af [1]kr", antaltelt, result);
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
                                        string valg5;
                                        valg5 = Console.ReadLine();
                                        switch (valg5)
                                        {
                                            case "Y":
                                                {
                                                    Console.WriteLine("Vi har godkendt dit køb. Vælg nu antal at luftmadraser");
                                                    int antalluft = 0;
                                                    antalluft = Convert.ToInt32(Console.ReadLine());
                                                    result = antalluft * 255;
                                                    Console.WriteLine("Du har valgt[0] luftmadraser til pris af 255,00kr - totalpris af [1]kr", antalluft, result);
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
                                        string valg6;
                                        valg6 = Console.ReadLine();
                                        switch (valg6)
                                        {
                                            case "Y":
                                                {
                                                    Console.WriteLine("Vi har godkendt dit køb. Vælg nu antal at soveposer");
                                                    int antalsove;
                                                    antalsove = Convert.ToInt32(Console.ReadLine());
                                                    result = antalsove * 150.50;
                                                    Console.WriteLine("Du har valgt[0] soveposer til pris af 255,00kr - totalpris af [1]kr", antalsove, result);
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
            Console.WriteLine("Tryk for at lukke");
            Console.ReadKey();
        }
    }
}

