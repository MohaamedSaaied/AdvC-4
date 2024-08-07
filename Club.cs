using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvC_4
{
    internal class Club
    {
        public int ClubID { get; set; }
        public String ClubName { get; set; }
        List<Employee> Members;
        public void AddMember(Employee E)
        {
            ///Try Register for EmployeeLayOff Event Here
            Members.Add(E);
            E.EmployeeLayOff += RemoveMember;
        }
        ///CallBackMethod
        public void RemoveMember

        (object sender, EmployeeLayOffEventArgs e)

        {
            ///Employee Will not be removed from the Club if Age>60
            ///Employee will be removed from Club if Vacation Stock < 0

            if (e.Cause == LayOffCause.VacationStockNegative)
             {
                 Members.Remove((Employee)sender);
             }
            
        }
    }
}
