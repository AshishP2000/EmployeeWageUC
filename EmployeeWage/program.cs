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
            //UC-10 Ability to Manage Employee Wage of multiple companies

            EmpWageComputation empWage = new EmpWageComputation();
            empWage.addCompanyEmpWage("dmart", 20, 30, 120);
            empWage.addCompanyEmpWage("relaince", 50, 80, 100);
            empWage.addCompanyEmpWage("Deloitte",65,84,67);
            
            empWage.CalculateEmpWage();
            

            Console.ReadLine();
        }
    }
}
