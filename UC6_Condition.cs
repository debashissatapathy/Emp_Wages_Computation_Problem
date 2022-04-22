using System;
using System.Collections.Generic;
using System.Text;

namespace Emp_Wages_Computation_Problem
{
    class UC6_Condition
    {
        public void total_Time()
        {
            int empWageperHr = 20;
            int fullTimeWorkingHr = 8;
            int partTimeWorkingHr = 4;
            int totalWorkHr = 100;
            int Working_Day = 20;
            int perDaySalary, monthlySalary = 0, dayCount = 1;
            Console.WriteLine("Job Type For Monthly salary :");            
            Random rand = new Random();
            int empType = rand.Next(3);
            switch (empType)
            {
                case 0:
                    Console.WriteLine("Not an Employee");
                    break;
                case 1:
                    while (totalWorkHr > 0 && (totalWorkHr / fullTimeWorkingHr) >= 0 && dayCount <= Working_Day)
                    {
                        perDaySalary = fullTimeWorkingHr * empWageperHr;
                        monthlySalary += perDaySalary;
                        Console.WriteLine("Salary of " + empType + " on day " + dayCount + " is: " + perDaySalary);
                        Console.WriteLine("Monthly Salary till date: " + monthlySalary);
                        totalWorkHr -= fullTimeWorkingHr;
                        dayCount++;
                    }
                    break;
                case 2:
                    while (totalWorkHr > 0 && (totalWorkHr / partTimeWorkingHr) >= 0 && dayCount <= Working_Day)
                    {
                        perDaySalary = partTimeWorkingHr * empWageperHr;
                        monthlySalary += perDaySalary;
                        Console.WriteLine("Salary of " + empType + " on day " + dayCount + " is: " + perDaySalary);
                        Console.WriteLine("Monthly Salary till date: " + monthlySalary);
                        totalWorkHr -= partTimeWorkingHr;
                        dayCount++;
                    }
                    break;
                





            }
        }
    }
}
