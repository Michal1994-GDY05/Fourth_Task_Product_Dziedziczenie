using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fourth_Task_Product_Dziedziczenie
{
    public interface IProdukt
    {
        string Nazwa { get; set; }
        decimal CenaNetto { get; set; }
        decimal VAT { get; }
        decimal CenaBrutto { get; }
        string KategoriaVAT { get; }
        string KrajPochodzenia { get; set; }
    }

    public interface IWielopak<T> where T : IProdukt
    {
        T Produkt { get; set; }
        ushort Ilosc { get; set; }
        decimal CenaNetto { get; set; }
        decimal CenaBrutto { get; }
        string KategoriaVAT { get; }
        string KrajPochodzenia { get; }
    }
}