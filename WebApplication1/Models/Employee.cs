using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Database;

namespace WebApplication1.Models
{
    public class Employee
    {
    }

    public class clsEmployee
    {
        public int ID { get; set; }
        public string EmployeeName { get; set; }
        public DateTime DOB { get; set; }
        public bool Gender { get; set; }
        public int DepartmentID { get; set; }
    }

    public class clsEmployeeReturn
    {
        public string ErrorNumber { get; set; }
        public string ErrorMessage { get; set; }
    }

    
}