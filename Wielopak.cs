using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fourth_Task_Product_Dziedziczenie
{
    class Wielopak
    {
        public Produkt Produkt { get; set; }
        public ushort Ilosc { get; set; }
        public decimal CenaNetto { get; set; }
        public decimal CenaBrutto => Produkt.CenaBrutto * Ilosc;
        public string KategoriaVAT => Produkt.KategoriaVAT;
        public string KrajPochodzenia => Produkt.KrajPochodzenia;

        public Wielopak(Produkt produkt, ushort ilosc, decimal cenaNetto)
        {
            Produkt = produkt;
            Ilosc = ilosc;
            CenaNetto = cenaNetto;
        }
    }
}
