using Fourth_Task_Product_Dziedziczenie;

class Program
{
    static void Main(string[] args)
    {
        ProduktSpozywczy produkt = new ProduktSpozywczy();
        produkt.Nazwa = "Jogurt";
        produkt.CenaNetto = 2.50m;
        produkt.KrajPochodzenia = "Polska";
        produkt.Kalorie = 150;
        produkt.Alergeny = new Dictionary<string, bool>()
            {
                { "Gluten", false },
                { "Mleko", true }
            };

        Console.WriteLine("Produkt: " + produkt.Nazwa);
        Console.WriteLine("Cena Netto: " + produkt.CenaNetto);
        Console.WriteLine("Cena Brutto: " + produkt.CenaBrutto);
        Console.WriteLine("Kategoria VAT: " + produkt.KategoriaVAT);
        Console.WriteLine("Kraj Pochodzenia: " + produkt.KrajPochodzenia);
        Console.WriteLine("Kalorie: " + produkt.Kalorie);
        Console.WriteLine("Alergeny:");
        foreach (var alergen in produkt.Alergeny)
        {
            Console.WriteLine(alergen.Key + ": " + (alergen.Value ? "Tak" : "Nie"));
        }

        Console.ReadKey();
    }
}
}