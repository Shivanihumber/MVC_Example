using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVC_Example.Models
{
    [Table("EmployeeTbl")]
    public class Employee
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string gender { get; set; }
        public string city { get; set; }

        public int departmentId { get; set; }
    }
}