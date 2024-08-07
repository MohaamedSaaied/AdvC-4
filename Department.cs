using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvC_4
{
    internal class Department
    {
        public int DeptID { get; set; }
        public string DeptName { get; set; }
        List<Employee> Staff=new List<Employee>();
        public void AddStaff(Employee E)
        {
            ///Try Register for EmployeeLayOff Event Here
            Staff.Add(E);
            E.EmployeeLayOff += RemoveStaff;
        }
        ///CallBackMethod
        public void RemoveStaff(object sender,

        EmployeeLayOffEventArgs e)

        {
            if (sender is Employee employee)
            {
                Staff.Remove(employee);
            }
        }
    }
}
