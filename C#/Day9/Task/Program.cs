namespace D9_SD43_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region dealing with time
            //DateTime d1 = new DateTime(2026, 12, 30);
            //DateTime d2 = new DateTime(2023, 12, 10);
            //TimeSpan d3 = d1 - d2;
            //Console.WriteLine(d3.Days);
            #endregion


            Employee e1 = new Employee( 1, new DateTime(1980, 12, 20), "ahmed");
            Employee e2 = new Employee( 2, new DateTime(1970, 12, 20), "medhat");
            Employee e3 = new Employee( 3, new DateTime(1960, 12, 20), "mohsn");
            salesEmployee e4 = new salesEmployee(500, 4, new DateTime(1940, 12, 20), "Sales zft");
            BoardMember e5 = new BoardMember( 5, new DateTime(1920, 12, 20),"Board zft bardo");
            #region Club
            //Club c1 = new Club(10, "Al Ahly");
            //c1.AddMember(e1);
            //c1.AddMember(e2);
            //c1.AddMember(e3);
            //c1.AddMember(e4);
            //c1.AddMember(e5);
            ////e5.VactionStock = -10;
            ////Console.WriteLine(e5.VactionStock + "Testing ");
            //Console.WriteLine(c1);
            //Console.WriteLine("ClubList");
            //Console.WriteLine(c1.ShowStaffList());
            //e1.RequestVacation(new DateTime(2023, 1, 10), new DateTime(2023, 3, 25));
            //Console.WriteLine(c1.ShowStaffList());
            //e1.EndOfYearOperation();
            //e2.EndOfYearOperation();
            //e3.EndOfYearOperation();
            //e5.EndOfYearOperation();
            //Console.WriteLine(e4.CheckTarget(600));
            //e5.Resign();
            //Console.WriteLine(c1.ShowStaffList()); 
            #endregion

            Console.WriteLine("======================================");
            #region Department
            //Department d1 = new Department(1, "HR");
            //d1.addStaff(e1);
            //d1.addStaff(e2);
            //d1.addStaff(e3);
            //d1.addStaff(e4);
            //d1.addStaff(e5);
            //Console.WriteLine("DepartmentList");
            //Console.WriteLine(d1.ShowStaffList());
            //e1.RequestVacation(new DateTime(2023, 1, 10), new DateTime(2023, 3, 25));
            //Console.WriteLine(d1.ShowStaffList());
            //e1.EndOfYearOperation();
            //e2.EndOfYearOperation();
            //e3.EndOfYearOperation();
            //e4.CheckTarget(600);
            //e5.Resign();
            //Console.WriteLine(d1.ShowStaffList());
            #endregion

        }
    }
}