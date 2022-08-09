using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 8;
            musteri1.Ad = "Buğrahan";
            musteri1.Soyad = "Gökçe";

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.AddCustomer(musteri1);
            musteriManager.DeleteCustomer(musteri1);
            musteriManager.ChangeCustomer(musteri1);

            Console.ReadLine();
        }
    }
}
