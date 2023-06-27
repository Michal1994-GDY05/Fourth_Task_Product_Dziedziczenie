using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fourth_Task_Product_Dziedziczenie
{
    class ProduktSpozywczyNaWage : ProduktSpozywczy
    {
        public ProduktSpozywczyNaWage(string nazwa, decimal cenaNetto, string kategoriaVAT, decimal kalorie, HashSet<string> alergeny)
            : base(nazwa, cenaNetto, kategoriaVAT, kalorie, alergeny)
        {
        }

        public override string KrajPochodzenia => throw new NotImplementedException();
    }
}
