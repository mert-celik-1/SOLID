
//Tek bir interface yerine kullanımlarına göre parçalanmış birden fazla interface ile işlemleri yürütmeliyiz.Yani her farklı sorumluluğun kendine özgü bir arayüzü olması gerekmektedir.
//Single responsibility ve interface segregation prensipleri birbirine oldukça yakın ve aynı amaca hizmet eden prensiplerdir. Tek fark ise Interface segregation arayüz(interface)ler ile ilgilenirken,
//Single responsibility sınıflarla ilgilenmektedir.
interface IPrint
{
    void Print();
}
interface IScan
{
    void Scan();
}
interface IFax
{
    void Fax();
}
interface IPrintDuplex
{
    void PrintDuplex();
}
class HPPrinter : IPrint, IScan, IFax, IPrintDuplex
{
    public void Fax()
    {
        //... Fax işlemleri ...
    }

    public void Print()
    {
        //... Print işlemleri ...
    }

    public void PrintDuplex()
    {
        //... Print Duplex işlemleri ...
    }

    public void Scan()
    {
        //... Scan işlemleri ...
    }
}
class SamsungPrinter : IPrint, IFax
{
    public void Fax()
    {
        //... Fax işlemleri ...
    }

    public void Print()
    {
        //... Print işlemleri ...
    }
}
class LexmarkPrinter : IFax, IPrint, IScan
{
    public void Fax()
    {
        //... Fax işlemleri ...
    }

    public void Print()
    {
        //... Print işlemleri ...
    }

    public void Scan()
    {
        //... Scan işlemleri ...
    }
}

