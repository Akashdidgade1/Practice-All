using Institute.Models;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Institute.Controllers
{
    public class SchoolController : Controller
    {

        string Connection = "Data Source=.\\sqlexpress;Initial Catalog=Interview;Integrated Security=True";
        public IActionResult Index()
        {

            List<School> list = new List<School>();
            SqlConnection con = new SqlConnection(Connection);
            SqlCommand cmd = new SqlCommand("Usp_School_Index", con);
            con.Open();
            SqlDataReader read = cmd.ExecuteReader();
            if (read.HasRows)
            {
                while (read.Read())
                {
                    list.Add(new School()
                    {
                        Id = read.GetInt32(0),
                        SchoolName = read.GetString(1),
                        Class = read.GetString(2),
                        DisplayOrderNumber = read.GetInt32(3),
                    });

                }
            }
            con.Close();
            return View(list);
        }
        [HttpGet]
        public IActionResult Create()
        {
            SchoolViewModel vm = new SchoolViewModel()
            {
                School = new School(),
                Schoolname = this.SchoolList().Select(a => new SelectListItem()
                {
                    Text = a.Name,
                    Value = a.Name.ToString()
                }),
                Classname = this.ClassList().Select(a => new SelectListItem()
                {
                    Text = a.Name,
                    Value = a.Name.ToString()
                }),

            };
            /*    School vm = new School()
                {

                    Schoolname = this.SchoolList().Select(a => new SelectListItem()
                    {
                        Text = a.Name,
                        Value = a.Name.ToString()
                    }),
                    Classname = this.ClassList().Select(a => new SelectListItem()
                    {
                        Text = a.Name,
                        Value = a.Name.ToString()
                    })


                };*/
            return View(vm);
        }
        [HttpPost]
        public IActionResult Create(SchoolViewModel model,IFormCollection form)
        {
            string Sname = form["Sname"];
            string Cname = form["Cname"];
            SqlConnection con = new SqlConnection(Connection);
            SqlCommand cmd = new SqlCommand("Usp_School_Create", con);
             cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Schoolname", Sname);
            cmd.Parameters.AddWithValue("@ClassName", Cname);
            cmd.Parameters.AddWithValue("@DisplayOrderNumber", model.School.DisplayOrderNumber);

            con.Open();
            int count = cmd.ExecuteNonQuery();
            if (count > 0)
            {
                return RedirectToAction("Index");
            }

            return View();

        }

        public List<SchoolName> SchoolList()
        {
            List<SchoolName> list = new List<SchoolName>();
            SqlConnection con = new SqlConnection(Connection);
            SqlCommand cmd = new SqlCommand("Usp_SchoolName_List", con);
            con.Open();
            SqlDataReader read = cmd.ExecuteReader();
            if (read.HasRows)
            {
                while (read.Read())
                {
                    list.Add(new SchoolName()
                    {
                        Id = read.GetInt32(0),
                        Name = read.GetString(1)
                    });

                }
            }
            con.Close();

            return list;
        }
        public List<ClassName> ClassList()
        {
            List<ClassName> list = new List<ClassName>();
            SqlConnection con = new SqlConnection(Connection);
            SqlCommand cmd = new SqlCommand("Usp_ClassName_List", con);
            con.Open();
            SqlDataReader read = cmd.ExecuteReader();
            if (read.HasRows)
            {
                while (read.Read())
                {
                    list.Add(new ClassName()
                    {
                        Id = read.GetInt32(0),
                        Name = read.GetString(1)
                    });

                }
            }
            con.Close();

            return list;
        }

    }
}
