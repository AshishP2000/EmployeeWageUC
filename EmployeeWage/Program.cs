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
            //UC-1 Find Employee is Present or Absent
            int empPresent = 1;
            Random random = new Random();
            //Generate
            int empCheck = random.Next(0, 2);
            Console.WriteLine("Random Value: " + empCheck);
            if (empPresent == empCheck)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
            Console.ReadLine();
        }
    }
}
