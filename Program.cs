using Fourth_Task_Product_Dziedziczenie;
using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        // Przykładowe użycie klas i interfejsów
        var produkt = new Produkt("Gruszka", 10.0m, "5%", "Polska");
        var produktSpozywczy = new ProduktSpozywczy("Pomarancza", 10.0m, "0%", "Polska", 1000.0m);

        var produktSpozywczy2 = new ProduktSpozywczy("Pomarancza", 10.0m, "0%", "Polska", 1000.0m);

        Console.WriteLine("Informacje o produkcie spożywczym:");
        Console.WriteLine("Nazwa: " + produktSpozywczy2.Nazwa);
        Console.WriteLine("Cena netto: " + produktSpozywczy2.CenaNetto);
        Console.WriteLine("Kategoria VAT: " + produktSpozywczy2.KategoriiVAT);
        Console.WriteLine("Kraj pochodzenia: " + produktSpozywczy2.KrajPochodzenia);
        Console.WriteLine("Kalorie na 100g: " + (produktSpozywczy2.Kalorie / 100) + " kcal/100g");

        Console.WriteLine("Informacje o produkcie spożywczym:");
        Console.WriteLine("Nazwa: " + produktSpozywczy.Nazwa);
        Console.WriteLine("Cena netto: " + produktSpozywczy.CenaNetto);
        Console.WriteLine("Kategoria VAT: " + produktSpozywczy.KategoriiVAT);
        Console.WriteLine("Kraj pochodzenia: " + produktSpozywczy.KrajPochodzenia);
        Console.WriteLine("Kalorie na 100g: " + produktSpozywczy.Kalorie);


        var wielopak = new Wielopak<ProduktSpozywczy>()
        {
            Produkt = produktSpozywczy,
            Ilosc = 5,
            CenaNetto = 10
        };

        Console.WriteLine($"Nazwa produktu: {wielopak.Produkt.Nazwa}");
        Console.WriteLine($"Cena brutto wielopaku: {wielopak.CenaBrutto}");
        Console.WriteLine($"Kraj: {wielopak.Produkt.KrajPochodzenia}");
        Console.WriteLine($"Kalorie: {wielopak.Produkt.Kalorie}");


        Console.ReadLine();
    }
}
