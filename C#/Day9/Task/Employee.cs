using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D9_SD43_Task
{
    internal class Employee
    {

        int vacationStock;
        public int EmployeeID { get; set; }
        public string EmpName { get; set; }
        public DateTime BirthDate { get; set; }
        //public  int  VactionStock { get => vacationStock; 
        //    set
        //    {
        //        if(value<0)
        //        {
        //            vacationStock = value;
        //            OnEmployeeLayOff(new EmployeeLayOffEventArgs() { cause = LayOffCause.OutOfStock ,EName=EmpName});
        //        }
        //        else
        //        {
        //            vacationStock = value;
        //        }
        //    }       
        //}
        public Employee( int _employeeID, DateTime _birthDate, string empName)
        {
            EmployeeID = _employeeID;
            BirthDate = _birthDate;
            vacationStock = 60;
            EmpName = empName;
        }

        public bool RequestVacation (DateTime from , DateTime to)
        {

            TimeSpan temp = to - from;

            if (temp.Days > vacationStock)
            {
                vacationStock -= temp.Days;
                OnEmployeeLayOff(new EmployeeLayOffEventArgs() { cause = LayOffCause.OutOfStock,EName=EmpName });
                return false;
            }
            else
            {
                vacationStock -= temp.Days;
                return true;
            }    
        }

        public virtual void EndOfYearOperation()
        {
            //reset vacation stock to the default value
            vacationStock = 60;
            //check his age if its bigger than 65 then fire the event
            int temp = DateTime.Now.Year - BirthDate.Year;
            if (temp > 60)
            {
                OnEmployeeLayOff(new EmployeeLayOffEventArgs() { cause = LayOffCause.OverAge ,EName=EmpName});
            }
        }

        public event EventHandler<EmployeeLayOffEventArgs> EmployeeLayOff;
        protected virtual void OnEmployeeLayOff(EmployeeLayOffEventArgs e)
        {
            EmployeeLayOff?.Invoke(this, e);
        }


    }



    enum LayOffCause
    {
        OverAge,OutOfStock,TargetFail,Resigned
    }

    class EmployeeLayOffEventArgs:EventArgs
    {
        public LayOffCause cause { get; set; }
        public string EName { get; set; }
    }

    class salesEmployee : Employee
    {
        public int AchievedTarget { get; set;}
        public salesEmployee(int _achievedTarget, int _employeeID, DateTime _birthDate, string empName) : base( _employeeID, _birthDate, empName)
        {
            AchievedTarget= _achievedTarget;
        }

        public bool CheckTarget (int quota)
        {
            if(AchievedTarget<=quota)
            {
                OnEmployeeLayOff(new EmployeeLayOffEventArgs() { cause= LayOffCause.TargetFail ,EName=EmpName});
                return false;
            }
            else
            {
                return true;
            }

        }
    }

    class BoardMember : Employee
    {
        public BoardMember( int _employeeID, DateTime _birthDate, string empName) : base( _employeeID, _birthDate, empName)
        {
        }
        public  override  void EndOfYearOperation()
        {
        }

        public void Resign()
        {
            OnEmployeeLayOff(new EmployeeLayOffEventArgs() { cause= LayOffCause.Resigned ,EName=EmpName});
        }
    }
}
