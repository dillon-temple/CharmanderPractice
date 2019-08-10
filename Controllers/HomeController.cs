using Microsoft.AspNetCore.Mvc;

namespace Portfolio{
     
     public class HomeController : Controller
     {
         // Requests
         // localhost:5000/
         [HttpGet("")]
         public ViewResult Index(){
             return View();
         }
         [HttpGet("Projects")]
         public ViewResult Projects(string username){
             return View();
         }
        [HttpGet("Contact")]
         public ViewResult Contact(string username){
             return View();
         }
     }
}