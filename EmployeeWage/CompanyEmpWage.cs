using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    public class CompanyEmpWage
    {
        public string Comapny;
        public int Emp_rate_per_hr, Max_working_days, Max_working_hr,Total_emp_wage;


        public CompanyEmpWage(string Comapny, int Emp_rate_per_hr, int Max_working_days, int Max_working_hr)
        {
            this.Comapny = Comapny;
            this.Emp_rate_per_hr = Emp_rate_per_hr;
            this.Max_working_days = Max_working_days;
            this.Max_working_hr = Max_working_hr;
        }

        public void setTotalEmpwage(int TOTAL_EMP_WAGE)
        {
            this.Total_emp_wage = TOTAL_EMP_WAGE;
        }

        public string toString()
        {
            return "Total Empwage for Company: " + this.Comapny + " is: " + this.Total_emp_wage;
        }

    }
}
