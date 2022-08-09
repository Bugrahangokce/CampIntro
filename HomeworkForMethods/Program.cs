using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkForMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 20;
            int sayi2 = 40;
            var result = Add(ref sayi1, sayi2);//ref keyword'u referans olarak "sayi1"in yerini değiştirir.

            int sayi3;
            int sayi4 = 140;
            var result2 = Add2(out sayi3, sayi4);//out keyword'u ref ile aynı işlevi görür fakat main içinde değişkene sayı tanımlamamıza gerek yoktur fakat metotta tanımlamamıza ihtiyaç vardır.


            Console.WriteLine(sayi1);
            Console.WriteLine(result);
            Console.WriteLine(sayi1);
            Console.WriteLine(result2);
            Console.WriteLine(sayi3);
            Console.ReadLine();
        }

        static int Add(ref int sayi1, int sayi2)
        {
            sayi1 = 10; //Main kısmında "Add" metotunu kullandığımız halde "sayi1" yerine hangi sayısal değeri verirsek verelim "Add" metotuna döndüğünde "sayi1" 10 değerini alacaktır.
            return sayi1 + sayi2;
        }

        static int Add2(out int sayi3, int sayi4)
        {
            sayi3 = 90; 
            return sayi3 + sayi4;
        }

    }
}
