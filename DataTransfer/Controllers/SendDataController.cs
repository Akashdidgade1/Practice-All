using DataTransfer.Models;
using Microsoft.AspNetCore.Mvc;
//using Newtonsoft.Json;
using System.Text.Json;
//using JsonSerializer = Newtonsoft.Json.JsonSerializer;

namespace DataTransfer.Controllers
{
    public class SendDataController : Controller
    {
        public IActionResult Index()
        {
            Student model= new Student()
            {
                   Id= 1,
                   Name="Akash"       
            };
            string user=JsonSerializer.Serialize (model);
            HttpContext.Session.SetString("key",user);

            Response.Cookies.Append("key", user);



            return View();
        }
    }
}
