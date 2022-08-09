using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class MusteriManager
    {
        public void AddCustomer(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad + " " + musteri.Soyad + " isimli kişi " + musteri.Id + " numaralı Id ile sisteme eklenmiştir.");
        }

        public void DeleteCustomer(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad + " " + musteri.Soyad + " isimli kişi " + musteri.Id + " numaralı Id ile sistemden silinmiştir.");
        }

        public void ChangeCustomer(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad + " " + musteri.Soyad + " isimli kişi " + musteri.Id + " numaralı Id ile sistemde tekrardan düzenlenmiştir.");
        }
    }
}
