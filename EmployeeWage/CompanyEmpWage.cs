using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    public class CompanyEmpWage
    {
        public string COMPANY;
        public int EMP_RATE_PER_HR, MAX_WORKING_DAYS, MAX_WORKING_HRS,TOTAL_EMP_WAGE;


        public CompanyEmpWage(string COMPANY, int EMP_RATE_PER_HR, int MAX_WORKING_DAYS, int MAX_WORKING_HRS)
        {
            this.COMPANY = COMPANY;
            this.EMP_RATE_PER_HR = EMP_RATE_PER_HR;
            this.MAX_WORKING_DAYS = MAX_WORKING_DAYS;
            this.MAX_WORKING_HRS = MAX_WORKING_HRS;
        }

        public void setTotalEmpwage(int TOTAL_EMP_WAGE)
        {
            this.TOTAL_EMP_WAGE=TOTAL_EMP_WAGE;
        }

        public string toString()
        {
            return "Total Empwage for Company: " + this.COMPANY + " is: " + this.TOTAL_EMP_WAGE;
        }

    }
}
