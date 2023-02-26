using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D9_SD43_Task
{
    internal class Club
    {
        public int ClubId { get; set; }
        public string ClubName { get; set; }

        List<Employee> members;

        public Club(int _id,string _clubName) { 
        members= new List<Employee>();
        ClubId = _id;  
        ClubName = _clubName;
        }

        public void AddMember (Employee e)
        {
            members.Add(e);
            e.EmployeeLayOff += RemoveMember;
        }
        public void RemoveMember (object sender,EmployeeLayOffEventArgs e)
        {
            if((sender is Employee emp )&&(emp !=null)) 
            {

                //if(e.cause==LayOffCause.OutOfStock)
                //{
                //    members.Remove(emp);
                //    Console.WriteLine($"Employee:{e.EName} was layed Of due to {e.cause}");
                //}else if (e.cause==LayOffCause.TargetFail) 
                //{
                //    members.Remove(emp);
                //    Console.WriteLine($"Employee:{e.EName} was layed Of due to {e.cause}");
                //}
                if(e.cause!=LayOffCause.Resigned)
                {
                members.Remove(emp);
                Console.WriteLine($"Employee:{e.EName} was layed Of due to {e.cause}");
                }
            };

        }
        public string ShowStaffList()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Employee emp in members)
            {
                sb.Append(emp.EmpName).Append(" , ");
            }
            return sb.ToString();
        }
        public override string ToString()
        {
            return $"Club Id: {this.ClubId} :: Club Name:{ClubName}";
        }

    }
}
