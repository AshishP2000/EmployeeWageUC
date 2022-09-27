using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    public class program
    {
        
        static void Main(string[] args)
        {
            //UC-12 Store Daily wage along with total wage

            EmpWageComputation empWage = new EmpWageComputation();
            empWage.AddCompanyEmpWage("dmart", 20, 30, 120);
            empWage.AddCompanyEmpWage("relaince", 50, 80, 100);
            empWage.AddCompanyEmpWage("Deloitte",65,84,67);

            empWage.IterateCalculateEmpWage();
            

            Console.ReadLine();
        }
    }
}
