using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {

            MyList<string> isimler = new MyList<string>();
            isimler.Add("Buğrahan");

            Console.WriteLine(isimler.Length);

            isimler.Add("Emir");

            Console.WriteLine(isimler.Length);

            foreach (var isim in isimler.Items)
            {
                Console.WriteLine(isim);
            }


            //string[] test = new string[] {"","","" };
            //Console.WriteLine(test.Length);
            Console.ReadLine();
        }
    }
}
