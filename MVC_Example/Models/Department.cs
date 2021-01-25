using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVC_Example.Models
{
    [Table("DepartmentTbl")]
    public class Department
    {
        public int Id { get; set; }
        public string name { get; set; }

        public List<Employee> Employees { get; set; }
    }
}