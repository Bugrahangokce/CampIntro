using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICreditManager needCreditManager = new NeedCreditManager();        
            ICreditManager vehicleCreditManager = new VehicleCreditManager();           
            ICreditManager housingCreditManager = new HousingCreditManager();
            
            ApplicationManager applicationManager = new ApplicationManager();
            applicationManager.MakeAnApplication(needCreditManager);

            Console.WriteLine("------");

            List<ICreditManager> credits = new List<ICreditManager>() {needCreditManager, vehicleCreditManager };

            applicationManager.MakeALoanPreInformation(credits);

            Console.ReadLine();
        }
    }
}
