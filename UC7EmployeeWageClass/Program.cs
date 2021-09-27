using System;

namespace UC7EmployeeWageClass
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = 0;
            Neww obj = new Neww();
            Random random = new Random();
            int empCheck = random.Next(0, 3);
            hours = obj.getHours(empCheck);
            Console.WriteLine("Total EmployeeWages is : " + obj.getEmpWage(hours));
        }
    }
}
