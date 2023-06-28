using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fourth_Task_Product_Dziedziczenie.Class
{
    public class Wielopak<T> : IWielopak<T> where T : IProdukt
    {
        public T Produkt { get; set; }
        public ushort Ilosc { get; set; }
        public decimal CenaNetto { get; set; }

        public decimal CenaBrutto => Produkt.CenaNetto * Ilosc * (1 + Produkt.KategoriiVAT / 100);
        public string KategoriaVAT => Produkt.KategoriaVAT;
        public string KrajPochodzenia => Produkt.KrajPochodzenia;

        public override string ToString()
        {
            return $"Produkt: {Produkt}\n" +
                   $"Ilość: {Ilosc}\n" +
                   $"Cena netto: {CenaNetto}\n" +
                   $"Cena brutto: {CenaBrutto}\n" +
                   $"Kategoria VAT: {KategoriaVAT}\n" +
                   $"Kraj pochodzenia: {KrajPochodzenia}\n";
        }
    }
}
