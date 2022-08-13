using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkForDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(1, "Laptop");
            myDictionary.Add(2, "Phone");
            myDictionary.Add(2, "Macbook");
            myDictionary.Add(3, "Macbook");

            myDictionary.ShowList();

            Console.ReadLine();
        }
    }
}
