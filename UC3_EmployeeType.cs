using System;
using System.Collections.Generic;
using System.Text;

namespace Emp_Wages_Computation_Problem
{
    class UC3_EmployeeType
    {
        public void fullTime_partTime()
        {
            int dailyWagesPerHr = 20;
            int workingHr;
            int fullTime = 1;
            Random rand = new Random();
            int EmpType = rand.Next(0, 2);
            if (EmpType == fullTime)
            {
                workingHr = 8;
                Console.WriteLine("FullTime Employee");
                Console.WriteLine("Daily wages " + workingHr * dailyWagesPerHr);
            }
            else
            {
                workingHr = 4;
                Console.WriteLine("Part Time Employee");
                Console.WriteLine("Daily wages " + workingHr * dailyWagesPerHr);
            }
        }
    }
}
