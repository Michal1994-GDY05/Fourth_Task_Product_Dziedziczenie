using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fourth_Task_Product_Dziedziczenie
abstract class ProduktSpozywczy : Produkt
{
    public decimal Kalorie { get; set; }
    public HashSet<string> Alergeny { get; set; }

    protected ProduktSpozywczy(string nazwa, decimal cenaNetto, string kategoriaVAT, decimal kalorie, HashSet<string> alergeny, Dictionary<string, decimal> stawkiVAT)
        : base(nazwa, cenaNetto, kategoriaVAT, stawkiVAT)
    {
        Kalorie = kalorie;
        Alergeny = alergeny;
    }

    public override decimal ObliczCeneBrutto()
    {
        decimal stawkaVAT = StawkiVAT[KategoriaVAT];
        return ObliczCeneBrutto(stawkaVAT);
    }

    protected decimal ObliczCeneBrutto(decimal stawkaVAT)
    {
        return CenaNetto * (1 + stawkaVAT);
    }
}