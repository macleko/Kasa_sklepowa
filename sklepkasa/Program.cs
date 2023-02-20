using System;
using System.Collections.Generic;

namespace Sklepik
{
    class sklep
    {
        static void Main()
        {

            var lista = new List<Produkty>
            {
                new Produkty { ID = 1001, Nazwa = "Masło Extra", CenaNetto = 6.50m},
                new Produkty { ID = 1002, Nazwa = "Chleb wiejski", CenaNetto = 4.50m},
                new Produkty { ID = 1003, Nazwa = "Makaron Babuni", CenaNetto = 9.20m},
                new Produkty { ID = 1004, Nazwa = "Dżem truskawkowy", CenaNetto = 8.10m},
                new Produkty { ID = 1005, Nazwa = "Kiełbasa myśliwska", CenaNetto = 29.00m},
                new Produkty { ID = 1006, Nazwa = "Szynka konserwowa", CenaNetto = 22.00m},
                new Produkty { ID = 1007, Nazwa = "Chipsy paprykowe", CenaNetto = 6.00m},
                new Produkty { ID = 1008, Nazwa = "Serek wiejski", CenaNetto = 3.50m},
                new Produkty { ID = 1009, Nazwa = "Sól kuchenna", CenaNetto = 2.70m},
                new Produkty { ID = 1010, Nazwa = "Cukier kryształ", CenaNetto = 3.20m},
            };


            while (true)
            {
                Console.WriteLine("Witaj w sklepie, wybierz co chcesz zrobić");
                Console.WriteLine("1. Pokaż listę produktów");
                Console.WriteLine("2. Przejdź do zakupów");
                Console.WriteLine("3. Zakończ program");
                Console.WriteLine();

                var wybor = Console.ReadLine();
               switch (wybor)
               { 
                case "1":

                    Console.WriteLine("Lista produktów");
                    foreach (var Produkty in lista)
                    {
                        Console.WriteLine(Produkty.ID + " | " + Produkty.Nazwa);
                    }
                    Console.WriteLine();

                break;
                
                case "2":

                    Console.WriteLine("Podaj kod produktu aby dodać go do koszyka");
                    Console.WriteLine("Aby otrzymać paragon naciśnij p");

                    var koszyk = new List<Produkty>();

                    decimal Suma = 0;

                    var kod = Console.ReadLine();

                    while (kod != "p")
                    {
                        int kodzik = int.Parse(kod);

                        var produkt = lista.FirstOrDefault(Produkty => Produkty.ID == kodzik);

                        if (produkt != null)
                        {
                            koszyk.Add(produkt);
                            Suma = Suma + produkt.CenaBrutto;

                            Console.WriteLine("Dodano do koszyka: " + produkt.Nazwa);
                        }
                        else
                        {
                            Console.WriteLine("Podaj poprawny kod produktu !!!");
                        }

                        kod = Console.ReadLine();

                    }

                    Console.WriteLine("Paragon za zakupy:");
                    Console.WriteLine("Data zakupu: " + DateTime.Now);
                    Console.WriteLine("Zakupione produkty:");
                    

                        foreach (var produkt in koszyk)
                    {
                            var produkcik = Math.Round(produkt.CenaBrutto, 2);
                            Console.WriteLine(produkt.Nazwa + " -> " + produkcik + "zł");
                    }

                    var Sumka = Math.Round(Suma, 2);

                        Console.WriteLine("Łączna kwota brutto do zapłaty: " + Sumka + "zł");

                break;

                case "3":
                    Console.WriteLine("Dowidzenia");
                    
                break;
                

                default:
                
                    Console.WriteLine("Wybierz opcje 1, 2 lub 3 !!!");

                break;
               }
            }
        }
    }
}