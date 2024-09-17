using System.ComponentModel.DataAnnotations;

namespace BtlMvc.Models
{
    public class Employee
    {
        [Key]
        public string EmployeeID {get;set;}
        public string? Adress {get;set;}

    }
}