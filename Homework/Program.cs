using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.productName = "Asus Laptop";
            urun1.prodcutProperty = "8GB Ram";
            urun1.productExplanation = "Gamer Laptop";
            urun1.productPrice = 16.599;

            Urun urun2 = new Urun();
            urun2.productName = "Casper Laptop";
            urun2.prodcutProperty = "16GB Ram";
            urun2.productExplanation = "Gamer Laptop";
            urun2.productPrice = 19.599;

            Urun urun3 = new Urun();
            urun3.productName = "Monster Laptop";
            urun3.prodcutProperty = "32GB Ram";
            urun3.productExplanation = "Gamer Laptop";
            urun3.productPrice = 25.599;

            Urun urun4 = new Urun();
            urun4.productName = "Gigabayt Laptop";
            urun4.prodcutProperty = "8GB Ram";
            urun4.productExplanation = "Gamer Laptop";
            urun4.productPrice = 8.599;

            Urun[] urunler = new Urun[] 
            { 
                urun1,
                urun2,
                urun3,
                urun4
            };

            for (int i = 0; i < urunler.Length; i++)
            {
                Console.WriteLine(urunler[i].productName + " : " + urunler[i].productPrice);
            }

            Console.WriteLine("For bitti.");

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.productName + " " + urun.prodcutProperty);
            }

            Console.WriteLine("Foreach bitti.");

            int forWhile = 0;
            while (forWhile < urunler.Length)
            {
                Console.WriteLine(urunler[forWhile].productExplanation + " " + urunler[forWhile].productPrice);
                forWhile++;
            }

            Console.WriteLine("forWhile bitti.");

            Console.ReadLine();
        }
    }

    class Urun
    {
        public string productName { get; set; }
        public string prodcutProperty { get; set; }
        public string productExplanation { get; set; }
        public double productPrice { get; set; }
    }
}
