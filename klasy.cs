using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fourth_Task_Product_Dziedziczenie
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace zadanie_4
    {
        public abstract class Produkt : IProdukt
        {
            public string Nazwa { get; set; }
            public decimal CenaNetto { get; set; }
            public abstract decimal CenaBrutto { get; }
            public string KrajPochodzenia { get; set; }

            protected static readonly Dictionary<string, decimal> VAT = new Dictionary<string, decimal>()
    {
        { "Spozywczy", 0m },
        { "Inny", 0.05m },
        { "Napoj", 0.08m },
        { "InneNapoje", 0.23m }
    };

            public string KategoriaVAT
            {
                get
                {
                    // Implementacja zwracająca klucz na podstawie wartości VAT
                    foreach (var pair in VAT)
                    {
                        if (pair.Value == CenaBrutto - CenaNetto)
                        {
                            return pair.Key;
                        }
                    }
                    throw new InvalidOperationException("Nieznana kategoria VAT");
                }
            }
        }

        public class ProduktSpozywczy : Produkt
        {
            public override decimal CenaBrutto => CenaNetto * (1 + VAT[KategoriaVAT]);
            public decimal Kalorie { get; set; }
            public Dictionary<string, bool> Alergeny { get; set; }
        }

        public class ProduktSpozywczyNaWage : ProduktSpozywczy
        {
            public decimal Waga { get; set; }
        }

        public class ProduktSpozywczyPaczka : ProduktSpozywczy
        {
            public decimal Waga { get; set; }
        }

        public class ProduktSpozywczyNapoj<T> : ProduktSpozywczyPaczka
        {
            public T Objetosc { get; set; }
        }

        public class Wielopak<T> : IWielopak<T> where T : IProdukt
        {
            public T Produkt { get; set; }
            public ushort Ilosc { get; set; }
            public decimal CenaNetto { get; set; }

            public decimal CenaBrutto => Produkt.CenaBrutto * Ilosc;
            public string KategoriaVAT => Produkt.KategoriaVAT;
            public string KrajPochodzenia => Produkt.KrajPochodzenia;
        }

    }
}
