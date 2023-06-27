using Fourth_Task_Product_Dziedziczenie;
using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        // Przykładowe użycie klas i interfejsów
        var produkt = new Produkt("Gruszka", 10.0m, "5%", "Polska");
        var produktSpozywczy = new ProduktSpozywczy("Pomarancza", 10.0m, "23%", "Polska");

        var wielopak = new Wielopak<ProduktSpozywczy>()
        {
            Produkt = produktSpozywczy,
            Ilosc = 5,
            CenaNetto = 10
        };

        Console.WriteLine($"Nazwa produktu: {wielopak.Produkt.Nazwa}");
        Console.WriteLine($"Cena brutto wielopaku: {wielopak.CenaBrutto}");
        Console.WriteLine($"Kraj: {wielopak.KrajPochodzenia}");

        Console.ReadLine();
    }
}
