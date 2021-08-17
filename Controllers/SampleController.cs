using System;
using System.Collections.Generic;
using System.Web.Mvc;
using WebApplication4.Models;
using WebApplication4.ViewModel;

namespace WebApplication4.Controllers
{
    public class SampleController : Controller
    {
        public ActionResult Index()
        {

            var workingcompany = new List<WorkingCompany>();
            workingcompany.Add(new WorkingCompany { Id = 1, Name = "Compunnel Inc" });
            workingcompany.Add(new WorkingCompany { Id = 2, Name = "Infopro Learning Inc" });
            workingcompany.Add(new WorkingCompany { Id = 3, Name = "Compunnel healtcare" });
            workingcompany.Add(new WorkingCompany { Id = 4, Name = "JobleticsPro" });
            workingcompany.Add(new WorkingCompany { Id = 5, Name = "Compunnel India" });
            workingcompany.Add(new WorkingCompany { Id = 6, Name = "Compunnel Canada" });
            workingcompany.Add(new WorkingCompany { Id = 7, Name = "LMG Healthcare" });

            var payroll = new List<PayRollCompany>();
            payroll.Add(new PayRollCompany { Id = 1, Name = "Compunnel Inc" });
            payroll.Add(new PayRollCompany { Id = 2, Name = "Infopro Learning Inc" });
            payroll.Add(new PayRollCompany { Id = 3, Name = "Compunnel healtcare" });
            payroll.Add(new PayRollCompany { Id = 4, Name = "JobleticsPro" });
            payroll.Add(new PayRollCompany { Id = 5, Name = "Compunnel India" });
            payroll.Add(new PayRollCompany { Id = 6, Name = "Compunnel Canada" });
            payroll.Add(new PayRollCompany { Id = 7, Name = "LMG Healthcare" });

            var status = new List<EmployeeStatus>();
            status.Add(new EmployeeStatus { Id = 1, Name = "Active" });
            status.Add(new EmployeeStatus { Id = 2, Name = "In Active" });

            var types = new List<EmployeeType>();
            types.Add(new EmployeeType { Id = 1, Name = "Consultant" });
            types.Add(new EmployeeType { Id = 2, Name = "Customer Contact" });
            types.Add(new EmployeeType { Id = 3, Name = "In-house Employee" });
            types.Add(new EmployeeType { Id = 4, Name = "Job Seeker" });
            types.Add(new EmployeeType { Id = 5, Name = "Sub-Contractor" });

            var batch = new List<BatchId>();
            batch.Add(new BatchId { Id = 1, Name = "0" });
            batch.Add(new BatchId { Id = 2, Name = "100" });
            batch.Add(new BatchId { Id = 3, Name = "200" });
            batch.Add(new BatchId { Id = 4, Name = "Referal-emp" });
            batch.Add(new BatchId { Id = 5, Name = "300" });

            var department = new List<Department>();
            department.Add(new Department { DepartmentsId = 1, Name = "Sales" });
            department.Add(new Department { DepartmentsId = 2, Name = "Recruitment" });
            department.Add(new Department { DepartmentsId = 3, Name = "Legal" });
            department.Add(new Department { DepartmentsId = 4, Name = "HR" });
            department.Add(new Department { DepartmentsId = 5, Name = "Accounting" });
            department.Add(new Department { DepartmentsId = 6, Name = "Custom Projects" });


            var hr = new List<HrRepresentative>();
            hr.Add(new HrRepresentative { Id = 1, Name = "Ashil" });
            hr.Add(new HrRepresentative { Id = 1, Name = "Manish" });
            hr.Add(new HrRepresentative { Id = 1, Name = "Gandhi" });

            var recruit = new List<ActualRecruitment>();
            recruit.Add(new ActualRecruitment { Id = 1, Name = "Ashil" });
            recruit.Add(new ActualRecruitment { Id = 1, Name = "Manish" });
            recruit.Add(new ActualRecruitment { Id = 1, Name = "Gandhi" });

            var location = new List<WorkingLocation>();
            location.Add(new WorkingLocation { Id = 1, Name = "Delhi" });
            location.Add(new WorkingLocation { Id = 1, Name = "Mumbai" });
            location.Add(new WorkingLocation { Id = 1, Name = "Goa" });

            var emp= new EmployeeAddEditViewModel

            {

                    Companies = workingcompany,
                    Payrollcompany = payroll,
                    EmployeeStatus = status,
                    Employeetype = types,
                    Departments = department,
                    batchids = batch,
                    representatives = hr,
                    recruitments = recruit,
                    Location = location
                };


            return View(emp);
        }
    

        public ActionResult create(Employee employee)
        {
            if (!ModelState.IsValid)
            {

                var workingcompany = new List<WorkingCompany>();
                workingcompany.Add(new WorkingCompany { Id = 1, Name = "Compunnel Inc" });
                workingcompany.Add(new WorkingCompany { Id = 2, Name = "Infopro Learning Inc" });
                workingcompany.Add(new WorkingCompany { Id = 3, Name = "Compunnel healtcare" });
                workingcompany.Add(new WorkingCompany { Id = 4, Name = "JobleticsPro" });
                workingcompany.Add(new WorkingCompany { Id = 5, Name = "Compunnel India" });
                workingcompany.Add(new WorkingCompany { Id = 6, Name = "Compunnel Canada" });
                workingcompany.Add(new WorkingCompany { Id = 7, Name = "LMG Healthcare" });

                var payroll = new List<PayRollCompany>();
                payroll.Add(new PayRollCompany { Id = 1, Name = "Compunnel Inc" });
                payroll.Add(new PayRollCompany { Id = 2, Name = "Infopro Learning Inc" });
                payroll.Add(new PayRollCompany { Id = 3, Name = "Compunnel healtcare" });
                payroll.Add(new PayRollCompany { Id = 4, Name = "JobleticsPro" });
                payroll.Add(new PayRollCompany { Id = 5, Name = "Compunnel India" });
                payroll.Add(new PayRollCompany { Id = 6, Name = "Compunnel Canada" });
                payroll.Add(new PayRollCompany { Id = 7, Name = "LMG Healthcare" });

                var status = new List<EmployeeStatus>();
                status.Add(new EmployeeStatus { Id = 1, Name = "Active" });
                status.Add(new EmployeeStatus { Id = 2, Name = "In Active" });

                var types = new List<EmployeeType>();
                types.Add(new EmployeeType { Id = 1, Name = "Consultant" });
                types.Add(new EmployeeType { Id = 2, Name = "Customer Contact" });
                types.Add(new EmployeeType { Id = 3, Name = "In-house Employee" });
                types.Add(new EmployeeType { Id = 4, Name = "Job Seeker" });
                types.Add(new EmployeeType { Id = 5, Name = "Sub-Contractor" });

                var batch = new List<BatchId>();
                batch.Add(new BatchId { Id = 1, Name = "0" });
                batch.Add(new BatchId { Id = 2, Name = "100" });
                batch.Add(new BatchId { Id = 3, Name = "200" });
                batch.Add(new BatchId { Id = 4, Name = "Referal-emp" });
                batch.Add(new BatchId { Id = 5, Name = "300" });

                var department = new List<Department>();
                department.Add(new Department { DepartmentsId = 1, Name = "Sales" });
                department.Add(new Department { DepartmentsId = 2, Name = "Recruitment" });
                department.Add(new Department { DepartmentsId = 3, Name = "Legal" });
                department.Add(new Department { DepartmentsId = 4, Name = "HR" });
                department.Add(new Department { DepartmentsId = 5, Name = "Accounting" });
                department.Add(new Department { DepartmentsId = 6, Name = "Custom Projects" });


                var hr = new List<HrRepresentative>();
                hr.Add(new HrRepresentative { Id = 1, Name = "Ashil" });
                hr.Add(new HrRepresentative { Id = 1, Name = "Manish" });
                hr.Add(new HrRepresentative { Id = 1, Name = "Gandhi" });

                var recruit = new List<ActualRecruitment>();
                recruit.Add(new ActualRecruitment { Id = 1, Name = "Ashil" });
                recruit.Add(new ActualRecruitment { Id = 1, Name = "Manish" });
                recruit.Add(new ActualRecruitment { Id = 1, Name = "Gandhi" });

                var location = new List<WorkingLocation>();
                location.Add(new WorkingLocation { Id = 1, Name = "Delhi" });
                location.Add(new WorkingLocation { Id = 1, Name = "Mumbai" });
                location.Add(new WorkingLocation { Id = 1, Name = "Goa" });


                var emp = new EmployeeAddEditViewModel
                {

                    Companies = workingcompany,
                    Payrollcompany = payroll,
                    EmployeeStatus = status,
                    Employeetype = types,
                    Departments = department,
                    batchids = batch,
                    representatives = hr,
                    recruitments = recruit,
                    Location = location
                };

                return View("Index", emp);
            }
            return Content("OK");
        }
    }
}


    



    
