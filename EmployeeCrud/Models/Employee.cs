using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EmployeeCrud.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        [Display(Name = "Employee Name")]
        public string EmployeeName { get; set; }
        public Department Department { get; set; }
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Display(Name = "Training Program")]
        public string TrainingProgram { get; set; }
        [Display(Name = "Dept Name")]
        public int DepartmentId { get; set; }
    }
}