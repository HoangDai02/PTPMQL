using System.ComponentModel.DataAnnotations;

namespace BtlMvc.Models
{
    public class Student
    {
        [Key]
       
        public string FullName { get; set; }
        public string  address {get; set;}
    }
}