using System.ComponentModel.DataAnnotations;

namespace DemoMVC.Models
{
    public class Employee
    {
        [Key]
       
        public string EmployeeID { get; set; }
        public string Fullname {get; set;}
        public string Address {get; set;}
    }
}