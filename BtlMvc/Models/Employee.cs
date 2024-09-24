using System.ComponentModel.DataAnnotations;

namespace BtlMvc.Models
{
    public class Employee
    {
        [Key]
        public string EmployeeID {get;set;}
<<<<<<< HEAD
        public string FullName {get;set;}
=======
        public  string FullName {get;set ;}
>>>>>>> fdebd2e5ea6cc259fc62bac5e2bd3065aed17447
        public string? Adress {get;set;}

    }
}