using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    public class Program
    {
        /// <summary>
        /// Defines Entry Point of Application
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //UC-2 Calculate Daily Employee Wage
            //we are not changing values of variable EMP_PRESENT and EMP_RATE_HR thats why we decalred it as constatnt
            const int EMP_PRESENT = 1;
            const int EMP_RATE_PER_HR = 20;
            int empHrs = 0,empWage=0;
            Random random = new Random();
            //Generate
            int empCheck = random.Next(0, 2);
            Console.WriteLine("Random Value: " + empCheck);
            if (EMP_PRESENT == empCheck)
            {
                empHrs = 8;
                Console.WriteLine("Employee is Present");
            }
            else
            {
                empHrs = 0;
                Console.WriteLine("Employee is Absent");
            }
            empWage = empHrs*EMP_RATE_PER_HR;
            Console.WriteLine("Employee Wage per Day is: "+empWage);
            Console.ReadLine();
        }
    }
}
