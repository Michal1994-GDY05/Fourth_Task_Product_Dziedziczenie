

namespace Fourth_Task_Product_Dziedziczenie
{
    public class Produkt : IProdukt
    {
        public Produkt(string nazwa, decimal cenaNetto, string kategoriaVAT, string krajPochodzenia)
        {
            Nazwa = nazwa;
            CenaNetto = cenaNetto;
            KategoriaVAT = kategoriaVAT;
            KrajPochodzenia = krajPochodzenia;
        }

        public string Nazwa { get; set; }

        private decimal cenaNetto;
        public decimal CenaNetto
        {
            get { return cenaNetto; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Cena netto nie może być ujemna");
                }
                cenaNetto = value;
            }
        }
        public string KategoriaVAT { get; set; }
        public virtual decimal KategoriiVAT => KategoriaVAT_Dictionary[KategoriaVAT];

        private static Dictionary<string, decimal> KategoriaVAT_Dictionary = new Dictionary<string, decimal>()
        {
            { "0%", 0 },
            { "5%", 5 },
            { "8%", 8 },
            { "23%", 23 }
        };

        public decimal CenaBrutto => CenaNetto * (1 + KategoriiVAT / 100);

        private string krajPochodzenia;
        public string KrajPochodzenia
        {
            get => krajPochodzenia;
            set
            {
                if (DostepneKraje.Contains(value))
                    krajPochodzenia = value;
                else

                    throw new ArgumentException("Nieprawidłowy kraj pochodzenia. ");
            }
        }

        private static readonly HashSet<string> DostepneKraje = new HashSet<string>()
        {
            "Polska",
            "Ukraina",
            "Hiszpania",
            "Włochy",
            "Słowacja",
            "Niemcy",
            "Norwegia"
        };
        public override string ToString()
        {
            return $"Nazwa: {Nazwa}\n" +
                   $"Cena netto: {CenaNetto}\n" +
                   $"Kategoria VAT: {KategoriaVAT}\n" +
                   $"Kraj pochodzenia: {KrajPochodzenia}\n" +
                   $"Cena brutto: {CenaBrutto}\n";
        }
    }
}
