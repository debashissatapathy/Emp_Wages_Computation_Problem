using System;
using System.Collections.Generic;
using System.Text;

namespace Emp_Wages_Computation_Problem
{
    class UC5_MonthlySalary
    {
        public void monthSal()
        {
            int dailyWagesPerHr = 20;
            int workingHr;
            int workingDays = 20;            
            Random rand = new Random();
            int EmpType=rand.Next(3);
            switch (EmpType)
            {
                case 1:
                    workingHr = 8;
                    Console.WriteLine("Fulltime employee getting salary per day : " + workingHr*dailyWagesPerHr );
                    Console.WriteLine("Fulltime employee getting monthly salary : " + workingHr * dailyWagesPerHr*workingDays);
                    break;
                case 2:
                    workingHr = 4;
                    Console.WriteLine("Parttime employee getting salary per day: " + workingHr*dailyWagesPerHr );
                    Console.WriteLine("Parttime employee getting monthly salary: " + workingHr * dailyWagesPerHr * workingDays);
                    break;
                default:
                    Console.WriteLine("Not a Employee");
                    break;
            }




        }
    }
}
