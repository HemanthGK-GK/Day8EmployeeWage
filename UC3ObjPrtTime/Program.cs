using System;

namespace UC3ObjPrtTime
{
    class Program
    {
        public void getEmpWage()
        {
            int fullTime = 2;
            int partTime = 1;
            int empRate = 20;

            int empWage = 0;
            int hours = 0;
            Random random = new Random();
            int empCheck = random.Next(0, 3);
            if (empCheck == fullTime)
                hours = 12;
            else if (empCheck == partTime)
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
