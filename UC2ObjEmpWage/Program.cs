using System;

namespace UC2ObjEmpWage
{
    class Program
    {
        public void getEmpWage()
        {
            int fullTime = 1;
            int empRate = 20;
            int empWage = 0;
            int hours = 0;
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if (empCheck == fullTime)
                hours = 8;
            else
                hours = 0;

            empWage = empRate * hours;
            Console.WriteLine("Employee Wage :" + empWage);
        }
        static void Main(string[] args)
        {
            Program ob = new Program();
            ob.getEmpWage();
        }
    }
}
