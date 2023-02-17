namespace D3SD43_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Employee[] empArry = new Employee[3];

            for (int i = 0; i < 3; i++)
            {
                Console.Clear();
                Console.WriteLine($"Enter Employee {i + 1} ID ");
                Employee e = new Employee();
                e.setId(int.Parse(Console.ReadLine()));
                Console.WriteLine($"Enter Employee {i + 1} Salary ");
                e.setSalary(double.Parse(Console.ReadLine()));
                Console.WriteLine($"Enter Employee {i + 1} hireDate ");
                Console.WriteLine("Enter Day");
                int day = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Month");
                int month = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Year");
                int year = int.Parse(Console.ReadLine());
                e.setHireDate(new HiringDate(day, month, year));
                Console.WriteLine($"Enter Employee {i + 1} secuirty level guest/developer/secretary/DBA/security officer");
                string sLevel = Console.ReadLine();
                if (sLevel == "guest")
                {
                    e.setSecuirtyLevel(secuirtyLevel.guest);
                }
                else if (sLevel == "developer")
                {
                    e.setSecuirtyLevel(secuirtyLevel.Developer);
                }
                else if (sLevel=="secretary")
                {
                    e.setSecuirtyLevel(secuirtyLevel.secretary);
                }
                else if (sLevel=="DBA")
                {
                    e.setSecuirtyLevel(secuirtyLevel.DBA);
                }
                else if (sLevel== "security officer")
                {
                    e.setSecuirtyLevel((secuirtyLevel)0b_0000_1111);
                }
                Console.WriteLine($"Enter Employee {i + 1} gender ");
                e.setGender((Gender)Enum.Parse(typeof(Gender),Console.ReadLine()));
                Console.WriteLine("============================================\n");
                empArry[i] = e;
            }

            for (int i = 0; i < empArry.Length; i++)
            {
                Console.WriteLine(empArry[i]);
            }


        }



        //till test
    }
}