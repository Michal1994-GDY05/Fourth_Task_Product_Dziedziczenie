

namespace Fourth_Task_Product_Dziedziczenie
{
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
