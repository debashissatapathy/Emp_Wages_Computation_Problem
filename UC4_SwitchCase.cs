using System;
using System.Collections.Generic;
using System.Text;

namespace Emp_Wages_Computation_Problem
{
    class UC4_SwitchCase
    {
        public void Emp_Type()
        {
            int dailyWagesPerHr = 20;
            int workingHr;
            Random rand = new Random();
            int EmpType=rand.Next(3);
            switch (EmpType)
            {
                case 1:
                    workingHr = 8;
                    Console.WriteLine("Fulltime employee getting salary per day : " + workingHr*dailyWagesPerHr );
                    break;
                case 2:
                    workingHr = 4;
                    Console.WriteLine("Parttime employee getting salary per day: " + workingHr*dailyWagesPerHr );
                    break;
                default:
                    Console.WriteLine("Not a Employee");
                    break;
            }




        }
    }
}
