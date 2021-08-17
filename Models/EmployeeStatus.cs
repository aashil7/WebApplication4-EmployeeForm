using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication4.Models
{
    public class EmployeeStatus
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }

    public class EmployeeType
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }

    public class BatchId
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }

    public class HrRepresentative
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }

    public class ActualRecruitment
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }

    public class WorkingLocation
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }

}