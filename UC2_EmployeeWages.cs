using System;
using System.Collections.Generic;
using System.Text;

namespace Emp_Wages_Computation_Problem
{
    class UC2_EmployeeWages
    {
        public void EmpWages()
        {
            int WagePerHr = 20;
            int EmpHr = 8;
            int DailyWages = WagePerHr * EmpHr;
            Console.WriteLine("Daily Salary is " + DailyWages);



        }
    }
}
