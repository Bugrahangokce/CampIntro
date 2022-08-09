using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";

            Urun[] urunler = new Urun[] 
            {
                urun1,
                urun2
            };

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("---------------------");

            }

            Console.WriteLine("Foreach bitti.");

            Console.WriteLine("------------Metotlar------------");

            //instance - örnek
            //encapsulation(ayrı ayrı yazmak yerine hepsini bir araya toplamak)

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Yeşil armut", 12);

            Add();
            var result2 = Add2(5,6,7);
            Console.WriteLine(result2);

            Console.WriteLine(Add4(2,34,34,3,43,43));

            Console.ReadLine();
        }

        static void Add()
        {
            Console.WriteLine("Added!");
        }

        static int Add2(int sayi1, int sayi2)
        {
            var result = sayi1 + sayi2;
            return result;
        }

        static int Add2(int sayi1, int sayi2, int sayi3)
        {
            var result = sayi1 + sayi2 + sayi3; 
            return result;
        }

        static int Add4(params int[] numbers)//param
        {
            return numbers.Sum();
        }
    }
}


//Do not repeat yourself - DRY - Clean Code - Best Practice
