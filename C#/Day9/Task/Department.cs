using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D9_SD43_Task
{
    internal class Department
    {
        public int DeptID { get; set; }
        public string DeptName { get; set; }

        List<Employee> Staff;

        public Department(int deptID, string deptName)
        {
            DeptID = deptID;
            DeptName = deptName;
            Staff = new();
        }

        public void addStaff(Employee employee)
        {
            employee.EmployeeLayOff += removeStaff;
            Staff.Add(employee);
        }

        public void removeStaff(object sender,EmployeeLayOffEventArgs e)
        {
            if((sender is Employee emp)&&(emp!=null))
            {
                int index=-1;
                for (int i = 0; i < Staff.Count; i++)
                {
                    if (Staff[i].EmployeeID == emp.EmployeeID)
                    {
                        index = i;
                        Staff[i].EmployeeLayOff -= removeStaff;
                    }

                }

                if (index != -1)
                {
                    Staff.RemoveAt(index);
                    Console.WriteLine($"Employee:{e.EName} was layed Of due to {e.cause}");
                
                }

            }

        }

        public string ShowStaffList()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Employee emp in Staff) {
                sb.Append(emp.EmpName).Append(" , ");
            }
            return sb.ToString();
        }
    }
}
