using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class ApplicationManager
    {
        public void MakeAnApplication(ICreditManager creditManager)
        {
            //Başvuran bilgilerini değerlendirme
            //
            creditManager.Calculate();
        }
        
        public void MakeALoanPreInformation(List<ICreditManager> credits)
        {
            foreach (var credit in credits)
            {
                credit.Calculate();
            }
        }
    }
}
