using Interview.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using System.Data.SqlClient;

namespace Interview.Controllers
{
    public class StudentController : Controller
    {
        string conn = "Data Source=.\\sqlexpress;Initial Catalog=Interview;Integrated Security=True";
        private readonly IWebHostEnvironment _hostEnviroment;

        public StudentController(IWebHostEnvironment hostEnviroment)
        {
            _hostEnviroment = hostEnviroment;
        }

        public IActionResult Index()
        {
            List<Student> list = new List<Student>();
            SqlConnection connection = new SqlConnection(conn);
            SqlCommand cmd = new SqlCommand("Select * from Memberform", connection);
            connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    list.Add(new Student()
                    {
                        Id = (int)reader["Id"],
                        Name = (string)reader["Name"],
                        PhoneNumber = (string)reader["PhoneNumber"],
                        Gender = (string)reader["Gender"],
                        Address = (string)reader["address"],
                        Image = (string)reader["Photo"]
                    });
                }
            };
            connection.Close();


            return View(list);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Student model,IFormFile? file)
        {

                string wwwRootPath = _hostEnviroment.WebRootPath;
                if (file != null)
                {
                    string filename = Guid.NewGuid().ToString();
                    var uploads = Path.Combine(wwwRootPath, @"Images\");
                    var extension = Path.GetExtension(file.FileName);

                    using (var filestreams = new FileStream(Path.Combine(uploads, filename + extension), FileMode.Create))
                    {
                        file.CopyTo(filestreams);
                    }
                    model.Image = @"Images\" + filename + extension;

                }
            
                List<Student> list = new List<Student>();
            SqlConnection connection = new SqlConnection(conn);
            SqlCommand cmd = new SqlCommand($"insert into Memberform values ('{model.Name}', '{model.PhoneNumber}','{model.Gender}','{model.Address}','{model.Image}') ", connection);
            connection.Open();
            int num = cmd.ExecuteNonQuery();
            if (num>0)
            {
                return RedirectToAction("Index");
            }
            connection.Close();

           return View();
        }
    }
}
