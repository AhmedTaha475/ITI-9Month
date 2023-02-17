using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D3SD43_Task
{
    internal struct Employee
    {

        int id;
        double salary;
        HiringDate hireDate;
        secuirtyLevel secuirtyLevel;
        Gender gender;

        public Employee(int _id,double _salary,HiringDate _hireDate,secuirtyLevel _secuirtyLevel,Gender _gender)
        {
            id= _id;
            salary= _salary;
            hireDate= _hireDate;
            secuirtyLevel= _secuirtyLevel;
            gender= _gender;
        }

        //setters and getters

        public int getId()
        {
            return id;
        }
        public double getSalary()
        {
            return salary;
        }
        public HiringDate getHireDate()
        {
            return hireDate;
        }
        public Gender getGender()
        {
            return gender;
        }
        public secuirtyLevel GetSecuirtyLevel()
        {
            return secuirtyLevel;
        }

        public void setId(int _id)
        {
            id= _id;
        }
        public void setSalary(double _salary)
        {
            salary= _salary;
        }
        public void setHireDate(HiringDate _hireDate)
        {
            hireDate= _hireDate;
        }
        public void setGender(Gender _gender)
        {
            gender= _gender;
        }
        public void setSecuirtyLevel(secuirtyLevel _secuirtyLevel)
        {
            secuirtyLevel= _secuirtyLevel;
        }

        public override string ToString()
        {
            return $"Employee Id:{id} __ Salary :{salary:c} __ hireDate:{hireDate.getDay()}/{hireDate.getMonth()}/{hireDate.getYear()}  __SecurityLevel:{secuirtyLevel} __ Gender:{gender}";
        }

    }

    
}
