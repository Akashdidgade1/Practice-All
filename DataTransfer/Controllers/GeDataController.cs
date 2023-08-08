using DataTransfer.Models;
using Microsoft.AspNetCore.Mvc;
//using Newtonsoft.Json;
using System.Text.Json;

namespace DataTransfer.Controllers
{
    public class GeDataController : Controller
    {
        public IActionResult Index()
        {
          string user=  HttpContext.Session.GetString("key");

           ViewBag.session= JsonSerializer.Deserialize<Student>(user);
            ViewBag.cookies = JsonSerializer.Deserialize<Student>(Request.Cookies["key"]);

         //   ViewBag.name=Json.(ViewBag);

            return View();
        }
    }
}
