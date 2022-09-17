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
            //UC-9 Ability to Save total Wage for each company

            EmpWageComputation dmart = new EmpWageComputation("dmart", 20, 30, 120);
            dmart.CalculateEmpWage();
            EmpWageComputation reliance = new EmpWageComputation("relaince", 30, 40, 150);
            reliance.CalculateEmpWage();

            Console.ReadLine();
        }
    }
}
