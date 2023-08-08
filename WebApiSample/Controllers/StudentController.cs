using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiSample.Models;

namespace WebApiSample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        AppDbContext _db;

        public StudentController(AppDbContext db)
        {
            _db = db;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var model=_db.Students.ToList();
            return Ok(model);
        }
        [HttpPost]
        public IActionResult Create(Student model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _db.Students.Add(model);
                    _db.SaveChanges();
                    return Ok("Created Succesfully");

                }
                catch (Exception ex)
                {

                    return BadRequest(ex.Message);
                }
            }
            return BadRequest(ModelState);
        
         
        }
        [HttpPut]
        public IActionResult Create(int id,Student model)
        {
            if (id==model.Id)
            {
                try
                {
                    _db.Students.Update(model);
                    _db.SaveChanges();
                    return Ok("Updated Succesfully");

                }
                catch (Exception ex)
                {

                    return BadRequest(ex.Message);
                }
            }
            return BadRequest(ModelState);


        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            if (id>=0)
            {
                try
                {
                    _db.Students.Remove(_db.Students.Find(id));
                    _db.SaveChanges();
                    return Ok("Deleted Succesfully");

                }
                catch (Exception ex)
                {

                    return BadRequest(ex.Message);
                }
            }
            return BadRequest(ModelState);


        }
        [Route("id")]
        [HttpGet]
        public IActionResult GetById(int id)
        {
            var model = _db.Students.Find(id);
            return Ok(model);
        }

    }
}
