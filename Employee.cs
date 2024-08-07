using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvC_4
{
    public  class Employee
    {

            public event

            EventHandler<EmployeeLayOffEventArgs> EmployeeLayOff;

            protected virtual void OnEmployeeLayOff

            (EmployeeLayOffEventArgs e)

            {
                EmployeeLayOff?.Invoke(this, e);
            }
            public int EmployeeID { get; set; }
            public DateTime BirthDate
            {
                get { throw new NotImplementedException(); }
                set { throw new NotImplementedException(); }
            }
            public int VacationStock
            {
                get { throw new NotImplementedException(); }
                set { throw new NotImplementedException(); }
            }
            public bool RequestVacation(DateTime From, DateTime To)
            {
                throw new NotImplementedException();
            }
            public void EndOfYearOperation()
            {
            if (VacationStock < 0)
            {
                OnEmployeeLayOff(new EmployeeLayOffEventArgs { Cause = LayOffCause.VacationStockNegative });
            }
            if (DateTime.Now.Year - BirthDate.Year > 60)
            {
                OnEmployeeLayOff(new EmployeeLayOffEventArgs { Cause = LayOffCause.AgeOverSixty });
            }
        }
        
    }
    public enum LayOffCause
    { ///Implement it YourSelf 
        VacationStockNegative,
        AgeOverSixty,
        FailedSalesTarget,
        Resigned
    }
    public class EmployeeLayOffEventArgs
    {
        public LayOffCause Cause { get; set; }
    }
}
