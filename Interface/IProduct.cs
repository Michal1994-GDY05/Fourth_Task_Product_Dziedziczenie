

namespace Fourth_Task_Product_Dziedziczenie
{
    public interface IProdukt
    {
        string Nazwa { get; set; }
        decimal CenaNetto { get; set; }
        decimal KategoriiVAT { get; }
        decimal CenaBrutto { get; }
        string KategoriaVAT { get; }
        string KrajPochodzenia { get; set; }
    }
}
