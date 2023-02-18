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
        string name;
        HiringDate hireDate;
        secuirtyLevel secuirtyLevel;
        Gender gender;

        public Employee(int _id,double _salary,HiringDate _hireDate,secuirtyLevel _secuirtyLevel,Gender _gender,string _name)
        {
            id= _id;
            salary= _salary;
            hireDate= _hireDate;
            secuirtyLevel= _secuirtyLevel;
            gender= _gender;
            name = _name;
        }

        //setters and getters

        public int Id { get { return id; } set { id = value; } }

        public string Name { get { return name; } set { name = value; } }
        public double Salary { get { return salary; } set { salary = value; } }

        public HiringDate HireDate { 
            get { return hireDate; } 
            set 
            {
                hireDate = value;
            }
        }
        public Gender Gender { get { return gender; } set { gender = value; } }
        public secuirtyLevel SecuirtyLevel { get {return secuirtyLevel; } set {secuirtyLevel=value ; } }
        
       


        public override string ToString()
        {
            return $"Employee Id:{id}__EmpName:{name} __ Salary :{salary:c} __ hireDate:{hireDate}  __SecurityLevel:{secuirtyLevel} __ Gender:{gender}";
        }

    }

    
}
