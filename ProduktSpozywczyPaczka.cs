using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fourth_Task_Product_Dziedziczenie
{
    class ProduktSpozywczyPaczka : ProduktSpozywczy
    {
        public decimal Waga { get; set; }

        public ProduktSpozywczyPaczka(string nazwa, decimal cenaNetto, string kategoriaVAT, decimal kalorie, HashSet<string> alergeny, decimal waga)
            : base(nazwa, cenaNetto, kategoriaVAT, kalorie, alergeny)
        {
            Waga = waga;
        }

        public override string KrajPochodzenia => throw new NotImplementedException();
    }
}
