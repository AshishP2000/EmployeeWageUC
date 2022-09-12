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
            //UC-6 Calculating Wages till a condition of total working hours or days is reached for a month
            //we are not changing values of variable EMP_PRESENT and EMP_RATE_HR thats why we decalred it as constatnt
            const int FULL_TIME = 1;
            const int PART_TIME = 2;
            const int EMP_RATE_PER_HR = 20;
            const int MAX_WORKING_DAYS = 20;
            const int MAX_WORKING_HRS = 100;
            int empHrs = 0,empWage=0,totalEmpWage=0,day=1,totalHrs=0;
            Random random = new Random();//Generate Random number
            
            while(day<=MAX_WORKING_DAYS && totalHrs<=MAX_WORKING_HRS)
            {
                int empCheck = random.Next(0, 3);
                //Console.WriteLine("Random Value: " + empCheck);
                
                switch (empCheck)
                {
                    case FULL_TIME:
                        empHrs = 8;
                        //Console.WriteLine("Full Time Employee is Present");
                        break;
                    case PART_TIME:
                        empHrs = 4;
                        //Console.WriteLine("Part Time Employee is Present");
                        break;
                    default:
                        empHrs = 0;
                        //Console.WriteLine("Employee is Absent");
                        break;
                }
                empWage = empHrs * EMP_RATE_PER_HR;
                Console.WriteLine("Employee Wage per on day{0} and Hrs:{1} is: {2} " ,day,totalHrs, empWage);
                totalEmpWage += empWage;
                day++;
                totalHrs+=empHrs;
            }
            
            Console.WriteLine("Employee Wage for Month is: "+ totalEmpWage);
            Console.ReadLine();
        }
    }
}
