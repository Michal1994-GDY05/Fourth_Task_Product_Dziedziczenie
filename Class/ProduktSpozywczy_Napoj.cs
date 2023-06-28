namespace Fourth_Task_Product_Dziedziczenie
{
    public class ProduktSpozywczy_Napoj<T> : ProduktSpozywczy_Paczka
    {
        public ProduktSpozywczy_Napoj(string nazwa, decimal cenaNetto, string kategoriaVAT, string krajPochodzenia, decimal kalorie, decimal waga, T objetosc)
            : base(nazwa, cenaNetto, kategoriaVAT, krajPochodzenia, kalorie, waga)
        {
            Objetosc = objetosc;
        }

        public T Objetosc { get; set; }

        public override string ToString()
        {
            return $"Nazwa: {Nazwa}\n" +
                   $"Cena netto: {CenaNetto}\n" +
                   $"Kategoria VAT: {KategoriaVAT}\n" +
                   $"Kraj pochodzenia: {KrajPochodzenia}\n" +
                   $"Kalorie: {Kalorie}\n" +
                   $"Waga: {Waga}\n" +
                   $"Objętość: {Objetosc}\n";
        }
    }
}
