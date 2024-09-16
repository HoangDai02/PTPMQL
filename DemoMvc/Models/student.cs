using System.ComponentModel.DataAnnotations;

namespace DemoMVC.Models
{
    public class Student
    {
        [Key]
       
        public string FullName { get; set; }
        public string  address {get; set;}
    }
}