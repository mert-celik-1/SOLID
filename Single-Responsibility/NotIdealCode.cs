using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Responsibility
{
    class Database
    {
        public void Connect()
        {
            //...
            Console.WriteLine("Veritabanı bağlantısı sağlanmıştır.");
        }
        public void Disconnect()
        {
            //...
            Console.WriteLine("Veritabanı bağlantısı kesilmiştir.");
        }
        public string State { get; set; }
        public List<Person> GetPersons()
        {
            return new() {
            new(){ Name = "test", Surname = "test" },
            };
        }
    }
}
