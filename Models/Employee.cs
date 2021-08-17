using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;


namespace WebApplication4.Models
{
    
    public class Employee
    {
        [ScaffoldColumn(false)]
        public int Id { get; set; }

     
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please Provide Name")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "First Name Should be min 3 and max 20 length")]
        public string Name { get; set; }


        //public int? City { get; set; }

        [Required (ErrorMessage = "Please Select Department")]
        public int? Department { get; set; }

        [Required(ErrorMessage = "Please Select WorkingCompany")]
        public int? WorkingCompany { get; set; }

        [Required(ErrorMessage = "Please Select PayRollCompany")]
        public int? PayRollCompany { get; set; }

        [Required(ErrorMessage = "Please Select EmployeeStatus")]
        public int? EmployeeStatus { get; set; }

       
        [Required(ErrorMessage = "Please Provide Gender")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Please Select EmployeeType")]
        public int EmployeeType { get; set; }

        [Required(ErrorMessage = "Please Provide SSN#")]
        public string SSN { get; set; }

        [Required(ErrorMessage = "Please Select Date Of Birth")]
        [DisplayName("Date Of Birth")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yy}")]
        public DateTime Date_Of_Birth { get; set; }

        [DisplayName("PersonalEmailId")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please Provide Personal Email")]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "Please Provide Valid Email")]
        public string PersonalEmailId { get; set; }


        [DisplayName("OfficialEmailId")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please Provide Official Email")]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "Please Provide Valid Email")]
        public string OfficialEmailId { get; set; }

        [Required(ErrorMessage = "Please Select Date Of Hire")]
        [DisplayName("Date Of Hire")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yy}")]
        public DateTime Date_Of_Hire { get; set; }

        [Required(ErrorMessage = "Please Select Batch Id")]
        public int? BatchId { get; set; }

        [Required(ErrorMessage = "Please Select HR Representative")]
        public int? HrRepresentative { get; set; }

        [Required(ErrorMessage = "Please Select Actual Recruitment")]
        public int? ActualRecruitment { get; set; }

        [Required(ErrorMessage = "Please Select Working Location")]
        public int? WorkingLocation { get; set; }

    }
}