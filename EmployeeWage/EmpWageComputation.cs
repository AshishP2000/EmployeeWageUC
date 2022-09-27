using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    public class EmpWageComputation
    {
        /// <summary>
        /// Defines Entry Point of Application
        /// </summary>
        /// <param name="args"></param>
        /// 
        
        List<CompanyEmpWage> companyEmpWagesList;
        Dictionary<string, CompanyEmpWage> CompanyToEmpwage;//Dictionary

        public EmpWageComputation()
        {
            companyEmpWagesList = new List<CompanyEmpWage>();
            CompanyToEmpwage = new Dictionary<string, CompanyEmpWage>();
        }

        public void AddCompanyEmpWage(string Comapny, int Emp_rate_per_hr, int Max_working_days, int Max_working_hr)
        {
            CompanyEmpWage companyEmpWage = new CompanyEmpWage(Comapny, Emp_rate_per_hr, Max_working_days, Max_working_hr);
            companyEmpWagesList.Add(companyEmpWage);
            CompanyToEmpwage.Add(Comapny,companyEmpWage);
        }

        public void IterateCalculateEmpWage()
        {
            for(int i=0;i<companyEmpWagesList.Count;i++)
            {
                int totalWage=CalculateEmpWage(companyEmpWagesList[i]);
                companyEmpWagesList[i].setTotalEmpwage(totalWage);
                
            }
        }

        public int CalculateEmpWage(CompanyEmpWage companyEmpWage)
        {
            //we are not changing values of variable EMP_PRESENT and EMP_RATE_HR thats why we decalred it as constatnt
            const int FULL_TIME = 1;
            const int PART_TIME = 2;
            int empHrs = 0, empWage = 0, totalEmpWage = 0, day = 1, totalHrs = 0;
            Random random = new Random();//Generate Random number

            while (day <= companyEmpWage.Max_working_days && totalHrs <= companyEmpWage.Max_working_hr)
            {
                int empCheck = random.Next(0, 3);
                //Console.WriteLine("Random Value: " + empCheck);

                switch (empCheck)
                {
                    case FULL_TIME:
                        empHrs = 8;
                        
                        break;
                    case PART_TIME:
                        empHrs = 4;
                        
                        break;
                    default:
                        empHrs = 0;
                        
                        break;
                }
                empWage = empHrs * companyEmpWage.Emp_rate_per_hr;
                totalEmpWage += empWage;
                day++;
                totalHrs += empHrs;
            }
            Console.WriteLine("Total Emp wage of {0} is {1}",companyEmpWage.Comapny,totalEmpWage);
            return totalEmpWage;
        }

        

    }
}
