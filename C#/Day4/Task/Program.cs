using D3SD43_Task;

namespace Day4SD43_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region task1
            //Employee[] empArry = new Employee[3];

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.Clear();
            //    int id;
            //    double salary;
            //    int day, month, year;
            //    secuirtyLevel secLevel;
            //    Gender gender;
            //    Employee e = new Employee();
            //    do
            //    {
            //        Console.WriteLine($"Enter Employee {i + 1} ID ");
            //    } while (!int.TryParse(Console.ReadLine(), out id));
            //    e.Id = id;
            //    do
            //    {
            //        Console.WriteLine($"Enter Employee {i + 1} Salary ");
            //    } while (!double.TryParse(Console.ReadLine(), out salary));
            //    e.Salary = salary;

            //    Console.WriteLine($"Enter Employee {i + 1} hireDate ");
            //    do
            //    {
            //        Console.WriteLine("Enter Day");
            //    } while (!int.TryParse(Console.ReadLine(), out day));
            //    do
            //    {
            //        Console.WriteLine("Enter Month");
            //    } while (!int.TryParse(Console.ReadLine(), out month));

            //    do
            //    {
            //        Console.WriteLine("Enter Year");
            //    } while (!int.TryParse(Console.ReadLine(), out year));
            //    e.HireDate = (new HiringDate(day, month, year));

            //    //Console.WriteLine($"Enter Employee {i + 1} secuirty level guest/developer/secretary/DBA/security officer");
            //    //string sLevel = Console.ReadLine();
            //    do
            //    {
            //        Console.WriteLine($"Enter Employee {i + 1} secuirty level guest/developer/secretary/DBA/security_officer");
            //    } while (!Enum.TryParse(Console.ReadLine(), true, out secLevel));
            //    e.SecuirtyLevel = secLevel;
            //    do
            //    {
            //        Console.WriteLine($"Enter Employee {i + 1} gender ");
            //    } while (!Enum.TryParse(Console.ReadLine(), true, out gender));

            //    e.Gender = gender;
            //    Console.WriteLine("============================================\n");
            //    e.Name = "mohamed";
            //    empArry[i] = e;
           // }

            //for (int i = 0; i < empArry.Length; i++)
            //{
            //    Console.WriteLine(empArry[i]);
            //}

    #endregion

    #region task2 indexers
    //EmployeeSearch employeeSearch = new EmployeeSearch();
    //Employee[] emps = new Employee[3]
    //{
    //            new Employee(1,2500,new HiringDate(5,5,1995),secuirtyLevel.DBA,Gender.male,"ahmed"),
    //            new Employee(2,2700,new HiringDate(9,5,1992),secuirtyLevel.security_officer,Gender.male,"mohameed"),
    //            new Employee(3,2800,new HiringDate(5,10,1991),secuirtyLevel.Developer,Gender.female,"mona"),

    //};
    //employeeSearch.Employees = emps;
    //        int[] ids = { 1, 2, 3 };
    //employeeSearch.NationalIDs = ids;


    //        Console.WriteLine(employeeSearch[1]);
    //        Console.WriteLine("================================");
    //        Console.WriteLine(employeeSearch["mohameed"]);
    //        Console.WriteLine("================================");
    //        Console.WriteLine(employeeSearch[new HiringDate(5, 10, 1991)]);

    //        //bool x = new HiringDate(5, 5, 1995).ToString() == new HiringDate(5, 5, 1995).ToString();
    //        //Console.WriteLine(x);
            #endregion


            #region pass ref by ref
            int[] ints = { 1, 2, 3, 4, 5 };

            Console.WriteLine(ints.GetHashCode());
            Console.WriteLine("=======================================Main");
            //sumArr(ints);
            //Console.WriteLine(ints[1]);
            sumArr(ref ints);
            Console.WriteLine(ints.GetHashCode());
            Console.WriteLine(ints[0]);
            Console.WriteLine(ints[1]);
            Console.WriteLine(ints[2]);
            Console.WriteLine(ints[3]);
            //Console.WriteLine(ints[4]);
            #endregion
        }

        //pass ref by value
        static int sumArr(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            arr = new int[4];
            arr[0] = 5;
            arr[1] = 6;
            arr[2] = 7;
            arr[3] = 8;
            Console.WriteLine(arr.GetHashCode());
            return sum;
        }
        //pass ref by ref
        static int sumArr(ref int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            arr = new int[4];
            arr[0] = 5;
            arr[1] = 6;
            arr[2] = 7;
            arr[3] = 8;
            Console.WriteLine(arr.GetHashCode());
            return sum;
        }
    }
}