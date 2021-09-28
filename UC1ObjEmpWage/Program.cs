using System;

namespace UC1ObjEmpWage
{
    class Program
    {
        public void Attendance()
        {
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if (empCheck == 1)
                Console.WriteLine("Employee is Present");
            else
                Console.WriteLine("Employee is Absent");
        }
        static void Main(string[] args)
        {
            Program ob = new Program();
            ob.Attendance();
        }
    }
}
