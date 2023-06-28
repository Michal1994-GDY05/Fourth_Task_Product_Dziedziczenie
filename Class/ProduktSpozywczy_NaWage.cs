

namespace Fourth_Task_Product_Dziedziczenie
{
    public class ProduktSpozywczy_NaWage : ProduktSpozywczy
    {
        public ProduktSpozywczy_NaWage(string nazwa, decimal cenaNetto, string kategoriaVAT, string krajPochodzenia, decimal kalorie)
            : base(nazwa, cenaNetto, kategoriaVAT, krajPochodzenia, kalorie)
        {
        }

        public decimal Waga { get; set; }
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

