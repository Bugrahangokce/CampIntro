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

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            RecourseManager recourseManager = new RecourseManager();
            //Alternatif
            //recourseManager.MakeAnRecourse(needCreditManager, new DatabaseLoggerService());
            List<ILoggerService> loggers = new List<ILoggerService>() { databaseLoggerService, fileLoggerService };
            recourseManager.MakeAnRecourse(needCreditManager, loggers);

            Console.WriteLine("------");

            List<ICreditManager> credits = new List<ICreditManager>() {needCreditManager, vehicleCreditManager };
           

            recourseManager.MakeALoanPreInformation(credits);

            Console.ReadLine();
        }
    }
}
