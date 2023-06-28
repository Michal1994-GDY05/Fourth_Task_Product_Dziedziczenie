

using System.Diagnostics.Metrics;

namespace Fourth_Task_Product_Dziedziczenie
{
    public class ProduktSpozywczy : Produkt
    {
        public ProduktSpozywczy(string nazwa, decimal cenaNetto, string kategoriaVAT, string krajPochodzenia, decimal kalorie)
    : base(nazwa, cenaNetto, kategoriaVAT, krajPochodzenia)
        {
            WalidujKategoriaVAT();
            WalidujKalorie(kalorie);
            Kalorie = kalorie;
            Alergeny = new HashSet<string>();
        }
        private void WalidujKategoriaVAT()
        {
            HashSet<string> dostepneKategorieVAT = new HashSet<string>()
        {
            "0%",
            "23%"
        };

            if (!dostepneKategorieVAT.Contains(KategoriaVAT))
            {
                throw new ArgumentException("Nieprawidłowa kategoria VAT dla produktu spożywczego. Dostępne wartości to 0%, 23%");
            }
        }


        public decimal Kalorie { get; set; }
        private void WalidujKalorie(decimal kalorie)
        {
            if (kalorie < 0)
            {
                throw new ArgumentException("Wartość kalorii nie może być ujemna.");
            }
        }


        public HashSet<string> Alergeny { get; set; }
        public List<string> SprawdzAlergeny()
        {
            var przewidywaneAlergeny = PrzewidywaneAlergeny();

            foreach (var alergen in Alergeny)
            {
                if (!przewidywaneAlergeny.Contains(alergen))
                {
                    throw new ArgumentException("Nieprawidłowy alergen: " + alergen);
                }
            }
            return Alergeny.ToList();
        }
        private static HashSet<string> PrzewidywaneAlergeny()
        {
            return new HashSet<string>()
        {
            "Orzeszki",
            "Gluten",
            "Mleko",
            "Jajka",
            "Soja",
            "Sezam",
            "Skorupki orzechów",
            "Ryby i mięczaki"
        };
        }

        public override string ToString()
        {
            return $"Nazwa: {Nazwa}\n" +
                   $"Cena netto: {CenaNetto}\n" +
                   $"Kategoria VAT: {KategoriaVAT}\n" +
                   $"Kraj pochodzenia: {KrajPochodzenia}\n" +
                   $"Cena brutto: {CenaBrutto}\n" +
                   $"Kalorie: {Kalorie}\n" +
                   $"Alergeny: {string.Join(", ", Alergeny)}\n";
        }
    }
}
