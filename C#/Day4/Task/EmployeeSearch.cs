using D3SD43_Task;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4SD43_Task
{
    internal class EmployeeSearch
    {
        int[] nationalIDs;
        Employee[] employees;
        public int[] NationalIDs { get { return nationalIDs; } set { nationalIDs = value; } }

        public Employee[] Employees { get { return employees; } set { employees = value; } }




        public Employee this[int nationID]
        {
            get {
                for (int i = 0; i < nationalIDs.Length; i++)
                {
                    if (nationalIDs[i]==nationID)
                    {
                        for (int j = 0; j < employees.Length; j++)
                        {
                            if (employees[j].Id == NationalIDs[i])
                                return employees[j];
                        }
                    }
                }



                return new Employee();
            }
            
        }


        public Employee this[string name]
        {
            get
            {
                for (int i = 0; i < employees.Length; i++)
                {
                    if (employees[i].Name == name)
                        return employees[i];
                };
                return new Employee();
            }
        }

        public Employee this[HiringDate date]
        {
            get
            {
                for (int i = 0; i < employees.Length; i++)
                {
                    if (employees[i].HireDate.ToString()==date.ToString())
                        return employees[i];
                }
                return new Employee();
            }
        }
    }
}
