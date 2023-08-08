using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;
using System.Text;
using System.Text.Json;
using WebApiClientMvc.Models;

namespace WebApiClientMvc.Controllers
{
    public class CategoryController : Controller
    {
        /*   HttpClient _client;
           string BaseAddress;*/


        public IActionResult Index()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7110/api/");
            string response = client.GetStringAsync(client.BaseAddress + "category").Result;
            List<category> Catmodel = JsonSerializer.Deserialize<List<category>>(response);


            return View(Catmodel);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(category model)
        {
            string data = JsonSerializer.Serialize(model);
            HttpClient client = new HttpClient();
            StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
            client.BaseAddress = new Uri("https://localhost:7110/api/");
            HttpResponseMessage response = client.PostAsync(client.BaseAddress + "category", content).Result;
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
        public IActionResult Edit(int id)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7110/api/");
            string response = client.GetStringAsync(client.BaseAddress + $"category/id?id={id}").Result;
            category model = JsonSerializer.Deserialize<category>(response);

            return View(model);
        }
        [HttpPost]
        public IActionResult Edit(category model)
        {
            try
            {
                string data = JsonSerializer.Serialize(model);
                StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("https://localhost:7110/api/");
                HttpResponseMessage response = client.PutAsync(client.BaseAddress + $"category?id={model.Id}", content).Result;
                if (response.IsSuccessStatusCode)
                {
                    TempData["success"] = "product details Update Succesfull";
                    return RedirectToAction("Index");
                }
            }
            catch (Exception ex)
            {
                TempData["errrMessage"] = ex.Message;
                return View();

                
            }
           // string text = "https://localhost:7110/api/Category?id=3";
           
            return View();
        }
        public IActionResult Details(int id)
        {
            string sample = "https://localhost:7110/api/Category/id?id=2";
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7110/api/");
            string response = client.GetStringAsync(client.BaseAddress + $"category/id?id={id}").Result;
            category model = JsonSerializer.Deserialize<category>(response);

            return View(model);
        
        }
        public IActionResult Delete(int id)
        {
            return View();
        }
        [HttpPost]
        public IActionResult Delete(category model)
        {
            string text = "https://localhost:7110/api/Category?id=2";
            try
            {
                string data = JsonSerializer.Serialize(model);
                StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("https://localhost:7110/api/");
                HttpResponseMessage response = client.GetAsync(client.BaseAddress + $"category?id={model.Id}").Result;
                if (response.IsSuccessStatusCode)
                {
                    TempData["success"] = "product deleted Succesfull";
                    return RedirectToAction("Index");
                }
            }
            catch (Exception ex)
            {
                TempData["errrMessage"] = ex.Message;
                return View();


            }
            return View();
        }


    }
}
