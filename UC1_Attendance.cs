using System;
using System.Collections.Generic;
using System.Text;

namespace Emp_Wages_Computation_Problem
{
    class UC1_Attendance
    {
        public void Attendance()
        {
            Random rand = new Random();
            int emp_Check = rand.Next(2);
            switch (emp_Check)
            {
                case 1:
                    Console.WriteLine("Employee is present");
                    break;
                case 0:
                    Console.WriteLine("Employee is absent");
                    break;
                default:
                    Console.WriteLine("Holiday");
                    break;
            }
        }  
    }
}
