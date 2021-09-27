using System;
using System.Collections.Generic;
using System.Text;

namespace UC7EmployeeWageClass
{
    class Neww
    {
        public int getEmpWage(int hours)
        {
            int empWage = 0;
            const int empRate = 20;
            int totalWage = 0;
            empWage = hours * empRate;
            totalWage += empWage;
            return totalWage;
        }

        public int getHours(int empCheck)
        {
            const int fullTime = 2;
            const int partTime = 1;
            const int totalDays = 20;
            int hours = 0;
            for (int day = 0; day < totalDays; day++)
            {
                switch (empCheck)
                {
                    case fullTime:
                        hours += 12;
                        break;
                    case partTime:
                        hours += 8;
                        break;
                    default:
                        hours += 0;
                        break;
                }

            }
            return hours;
        }
    }
}
