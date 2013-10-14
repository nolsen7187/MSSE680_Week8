using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PresentationWebForms.Models
{
    public class WebUserTable
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public Nullable<int> CustomerId { get; set; }
        public Nullable<int> EmployeeId { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Employee Employee { get; set; }
    }
}