using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fourth_Task_Product_Dziedziczenie
{
    class ProduktSpozywczyNapoj : ProduktSpozywczyPaczka
    {
        public uint Objetosc { get; set; }

        public ProduktSpozywczyNapoj(string nazwa, decimal cenaNetto, string kategoriaVAT, decimal kalorie, HashSet<string> alergeny, decimal waga, uint objetosc)
            : base(nazwa, cenaNetto, kategoriaVAT, kalorie, alergeny, waga)
        {
            Objetosc = objetosc;
        }
    }

}
