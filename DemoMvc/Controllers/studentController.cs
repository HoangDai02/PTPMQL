using Microsoft.AspNetCore.Mvc; // Đối với ASP.NET Core

namespace DemoMvc.Controllers
{
    public class StudentController : Controller
    
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
    public IActionResult Index ( string FullName, string address )
    {
        string  str0utput ="xin chao" + FullName + address;
        @ViewBag.thongbao = str0utput ;
        return View ();
    }
    }
}