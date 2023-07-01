
//Bir sınıf ya da fonksiyon var olan özellikleri korumalı yani davranışını değiştirmiyor olmalı ve yeni özellikler kazanabilmelidir.
//Sınıflarımız/fonksiyonlarımız değişikliğe kapalı ancak yeni davranışların eklenmesine açık olmalıdır.
//Open Sınıf için yeni davranışlar eklenebilmesini sağlar. Gereksinimler değiştiğinde, yeni gereksinimlerin karşılanabilmesi için bir sınıfa yeni veya farklı davranışlar eklenebilir olmasıdır.
//Closed Bir sınıf temel özelliklerinin değişimi ise mümkün olmamalıdır.



namespace Open_Closed
{
    class SendInvoice
    {
        public void Gonder(Invoice invoice, int amount)
        {
            invoice.GetInvoiceDiscount(amount);
        }

    }
    public interface Invoice
    {
        double GetInvoiceDiscount(double amount);
    }

    public class FinalInvoice : Invoice
    {
        public double GetInvoiceDiscount(double amount)
        {
            return GetInvoiceDiscount(amount) - 50;
        }
    }
    public class ProposedInvoice : Invoice
    {
        public double GetInvoiceDiscount(double amount)
        {
            return GetInvoiceDiscount(amount) - 40;
        }
    }
    public class RecurringInvoice : Invoice
    {
        public double GetInvoiceDiscount(double amount)
        {
            return GetInvoiceDiscount(amount) - 30;
        }
    }


}
