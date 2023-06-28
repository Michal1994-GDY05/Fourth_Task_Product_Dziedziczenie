

namespace Fourth_Task_Product_Dziedziczenie
{
    public class ProduktSpozywczy_Paczka : ProduktSpozywczy
    {
        public ProduktSpozywczy_Paczka(string nazwa, decimal cenaNetto, string kategoriaVAT, string krajPochodzenia, decimal kalorie, decimal waga)
    : base(nazwa, cenaNetto, kategoriaVAT, krajPochodzenia, kalorie)
        {
            Waga = waga;
        }

        private decimal waga;

        public decimal Waga
        {
            get { return waga; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Waga nie może być ujemna.");
                }
                waga = value;
            }
        }

        public override string ToString()
        {
            return $"Nazwa: {Nazwa}\n" +
                   $"Cena netto: {CenaNetto}\n" +
                   $"Kategoria VAT: {KategoriaVAT}\n" +
                   $"Kraj pochodzenia: {KrajPochodzenia}\n" +
                   $"Cena brutto: {CenaBrutto}\n" +
                   $"Kalorie: {Kalorie}\n" +
                   $"Waga: {Waga}\n";
        }
    }
}
