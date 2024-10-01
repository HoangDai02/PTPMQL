using System.ComponentModel.DataAnnotations;
namespace DemoMVC.Models
{
    public class Person
    {
        [Key]
        public string Cancuoccongdan { get; set; }
        public string Hoten {get;set;}
        public string Quequan {get;set;}
        
    }
}