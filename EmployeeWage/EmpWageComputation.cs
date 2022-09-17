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
        private int numOfCompany = 0;
        private CompanyEmpWage[] companyEmpWageArray;


        public EmpWageComputation()
        {
            this.companyEmpWageArray = new CompanyEmpWage[5];    
        }

        public void addCompanyEmpWage(string COMPANY, int EMP_RATE_PER_HR, int MAX_WORKING_DAYS, int MAX_WORKING_HRS)
        {
            companyEmpWageArray[this.numOfCompany] = new CompanyEmpWage(COMPANY, EMP_RATE_PER_HR, MAX_WORKING_DAYS, MAX_WORKING_HRS);
            numOfCompany++;
        }

        public void CalculateEmpWage()
        {
            for (int i = 0; i < numOfCompany; i++)
            {
                companyEmpWageArray[i].setTotalEmpwage(this.CalculateEmpWage(this.companyEmpWageArray[i]));
                Console.WriteLine(this.companyEmpWageArray[i].toString());
            }
        }

        private int CalculateEmpWage(CompanyEmpWage companyEmpWage)
        {
            //we are not changing values of variable EMP_PRESENT and EMP_RATE_HR thats why we decalred it as constatnt
            const int FULL_TIME = 1;
            const int PART_TIME = 2;
            int empHrs = 0, empWage = 0, totalEmpWage = 0, day = 1, totalHrs = 0;
            Random random = new Random();//Generate Random number

            while (day <= companyEmpWage.MAX_WORKING_DAYS && totalHrs <= companyEmpWage.MAX_WORKING_HRS)
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
                empWage = empHrs * companyEmpWage.EMP_RATE_PER_HR;
                totalEmpWage += empWage;
                day++;
                totalHrs += empHrs;
            }
            return totalEmpWage;
        }

    }
}
