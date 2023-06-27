using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fourth_Task_Product_Dziedziczenie
{
    class Produkt
    {
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
        private string kategoriaVAT;
        public string KategoriaVAT
        {
            get { return kategoriaVAT; }
            set
            {
                if (!DostepneKategorieVAT.ContainsKey(value))
                {
                    throw new ArgumentException("Nieprawidłowa kategoria VAT");
                }
                kategoriaVAT = value;
            }
        }
        public decimal CenaBrutto => ObliczCeneBrutto();
        public string KrajPochodzenia { get; }

        private static Dictionary<string, decimal> DostepneKategorieVAT = new Dictionary<string, decimal>
    {
        { "A", 0.23m },
        { "B", 0.08m },
        { "C", 0.05m },
        { "D", 0.00m }
    };

        public Produkt(string nazwa, decimal cenaNetto, string kategoriaVAT, Dictionary<string, decimal> stawkiVAT, string krajPochodzenia)
        {
            Nazwa = nazwa;
            CenaNetto = cenaNetto;
            WalidujKategorieVAT(kategoriaVAT, stawkiVAT);
            KategoriaVAT = kategoriaVAT;
            KrajPochodzenia = krajPochodzenia;
        }

        private void WalidujKategorieVAT(string kategoriaVAT, Dictionary<string, decimal> stawkiVAT)
        {
            if (!stawkiVAT.ContainsKey(kategoriaVAT))
            {
                throw new ArgumentException("Nieprawidłowa kategoria VAT");
            }
        }

        public virtual decimal ObliczCeneBrutto()
        {
            decimal stawkaVAT = DostepneKategorieVAT[KategoriaVAT];
            return CenaNetto * (1 + stawkaVAT);
        }
    }
}
