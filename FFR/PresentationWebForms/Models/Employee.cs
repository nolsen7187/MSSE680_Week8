using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PresentationWebForms.Models
{
    public class Employee
    {
        public Employee()
        {
            this.WebUserTables = new HashSet<WebUserTable>();
        }
        [Required]
        public int EmployeeId { get; set; }
        [Required]
        public string EmployeeFirstName { get; set; }
        [Required]
        public string EmployeeLastName { get; set; }
        public string EmployeePhone { get; set; }
        [Required]
        public string Employeetype { get; set; }

        public virtual ICollection<WebUserTable> WebUserTables { get; set; }
    }
}