using System.ComponentModel.DataAnnotations;

namespace BtlMvc.Models
{
    public class Employee
    {
        [Key]
        public required string EmployeeID {get;set;}
        public string FullName {get;set;}

        public string? Adress {get;set;}

    }
}