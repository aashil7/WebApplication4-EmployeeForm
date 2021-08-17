using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication4.Models;


namespace WebApplication4.ViewModel
{
    public class EmployeeAddEditViewModel
    {
        public Employee Employee { get; set; }

        public List<Department> Departments { get; set; }

        public List<WorkingCompany> Companies { get; set; }

        public List<PayRollCompany> Payrollcompany { get; set; }

        public List<EmployeeStatus> EmployeeStatus { get; set; }

        public List<EmployeeType> Employeetype { get; set; }
        public List<BatchId> batchids { get; set; }
        public List<HrRepresentative> representatives { get; set; }
        public List<ActualRecruitment> recruitments { get; set; }

        public List<WorkingLocation> Location { get; set; }
        public List<AppRefData> StatusList { get; internal set; }
    }
}