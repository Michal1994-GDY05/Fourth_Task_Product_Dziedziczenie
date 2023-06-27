using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fourth_Task_Product_Dziedziczenie
{
    public class Produkt : IProdukt
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

        public decimal VAT => VATDictionary[KategoriaVAT];
        public decimal CenaBrutto => CenaNetto * (1 + VAT / 100);

        private string krajPochodzenia;
        public string KrajPochodzenia
        {
            get => krajPochodzenia;
            set
            {
                if (DostepneKraje.Contains(value))
                    krajPochodzenia = value;
                else
                    throw new ArgumentException("Nieprawidłowy kraj pochodzenia.");
            }
        }

        public string KategoriaVAT { get; set; }

        protected static Dictionary<string, decimal> VATDictionary = new Dictionary<string, decimal>()
    {
        { "0%", 0 },
        { "5%", 5 },
        { "8%", 8 },
        { "23%", 23 }
    };

        private static readonly HashSet<string> DostepneKraje = new HashSet<string>()
    {
        "Polska",
        "Niemcy",
        "Francja",
        "Włochy"
    };

        public Produkt(string nazwa, decimal cenaNetto, string kategoriaVAT, string krajPochodzenia)
        {
            Nazwa = nazwa;
            CenaNetto = cenaNetto;
            KategoriaVAT = kategoriaVAT;
            KrajPochodzenia = krajPochodzenia;
        }
    }

        public class ProduktSpozywczy : Produkt
        {
        public ProduktSpozywczy(string nazwa, decimal cenaNetto, string kategoriaVAT, string krajPochodzenia) 
            : base(nazwa, cenaNetto, kategoriaVAT, krajPochodzenia)
        {
        }

        public decimal VAT => VATDictionary[KategoriaVAT];
        }

        public class ProduktSpozywczyNaWage : ProduktSpozywczy
        {
        public ProduktSpozywczyNaWage(string nazwa, decimal cenaNetto, string kategoriaVAT, string krajPochodzenia) : base(nazwa, cenaNetto, kategoriaVAT, krajPochodzenia)
        {
        }

        public decimal Waga { get; set; }
        }

        public class ProduktSpozywczyPaczka : ProduktSpozywczy
        {
        public ProduktSpozywczyPaczka(string nazwa, decimal cenaNetto, string kategoriaVAT, string krajPochodzenia) : base(nazwa, cenaNetto, kategoriaVAT, krajPochodzenia)
        {
        }

        public decimal Waga { get; set; }
        }

        public class ProduktSpozywczyNapoj<T> : ProduktSpozywczyPaczka
        {
        public ProduktSpozywczyNapoj(string nazwa, decimal cenaNetto, string kategoriaVAT, string krajPochodzenia) : base(nazwa, cenaNetto, kategoriaVAT, krajPochodzenia)
        {
        }

        public T Objetosc { get; set; }
        }

        public class Wielopak<T> : IWielopak<T> where T : IProdukt
        {
            public T Produkt { get; set; }
            public ushort Ilosc { get; set; }
            public decimal CenaNetto { get; set; }

            public decimal CenaBrutto => Produkt.CenaNetto * Ilosc * (1 + Produkt.VAT / 100);
            public string KategoriaVAT => Produkt.KategoriaVAT;
            public string KrajPochodzenia => Produkt.KrajPochodzenia;
        }
    }
