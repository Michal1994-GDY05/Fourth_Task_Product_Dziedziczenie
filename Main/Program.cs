using Fourth_Task_Product_Dziedziczenie;
using Fourth_Task_Product_Dziedziczenie.Class;

class Program
{
    static void Main()
    {
        Produkt produkt = new Produkt("Banan", 9.00m, "23%", "Hiszpania");
        Console.WriteLine(produkt.ToString());

        ProduktSpozywczy produktSpozywczy = new ProduktSpozywczy("Brownie", 9.00m, "0%", "Niemcy", 1600m);
        produktSpozywczy.Alergeny.Add("Orzeszki");
        produktSpozywczy.Alergeny.Add("Gluten");
        Console.WriteLine(produktSpozywczy.ToString());

        var produktSpozywczy_Napoj = new ProduktSpozywczy_Napoj<uint>("Napój", 5.0m, "23%", "Włochy", 100.0m, 250, 20000);
        Console.WriteLine(produktSpozywczy_Napoj.ToString());

        var produktSpozywczy_NaWage = new ProduktSpozywczy_NaWage("Pomarancza", 10.0m, "0%", "Hiszpania", 1000.0m);
        produktSpozywczy_NaWage.Alergeny.Add("Cukier");
        Console.WriteLine(produktSpozywczy_NaWage.ToString());

        ProduktSpozywczy_Paczka paczka = new ProduktSpozywczy_Paczka("Mleko", 3.50m, "0%", "Polska", 120, 1.5m);
        Console.WriteLine(paczka.ToString());

        Produkt produkt_wielopak = new Produkt("Czekolada", 2.50m, "5%", "Norwegia");
        Wielopak<Produkt> wielopak = new Wielopak<Produkt>()
        {
            Produkt = produkt_wielopak,
            Ilosc = 5,
            CenaNetto = 10.00m
        };

        Console.WriteLine(wielopak.ToString());






        //var wielopak = new Wielopak<Produkt>()
        //{
        //    Produkt = produkt,
        //    Ilosc = 5,
        //    CenaNetto = 10
        //};

        //Console.WriteLine($"Nazwa produktu: {wielopak.Produkt.Nazwa}");
        //Console.WriteLine($"Cena brutto wielopaku: {wielopak.CenaBrutto}");
        //Console.WriteLine($"Kraj: {wielopak.Produkt.KrajPochodzenia}");
        ////Console.WriteLine($"Kalorie: {wielopak.Produkt.Kalorie}");


        //Console.ReadLine();
    }
}
