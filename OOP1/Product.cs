using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    internal class Product //Entity
    {
        public int Id { get; set; }//Primary key
        public int CategoryId { get; set; }//Referans anahtarı
        public string ProductName { get; set; }
        public double UnitePrice { get; set; }
        public int UnitsInStock { get; set; }

        


    }
}
