using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EmployeeCrud.Models;

namespace EmployeeCrud.ViewModels
{
    public class EmployeeViewModel
    {
        public IEnumerable<Department> Department { get; set; }
        public Employee Employee { get; set; }
    }
}