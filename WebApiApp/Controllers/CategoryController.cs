using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiApp.Models;

namespace WebApiApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        AppDbContext _db;

        public CategoryController(AppDbContext db)
        {
            _db = db;
        }
        [HttpGet]
        [Route("id")]
        public IActionResult Details(int id)
        {
            var model = _db.Categories.Find(id);
            return Ok(model);
        }
        [HttpGet]
    
        public IActionResult Index()
        {
            var model=_db.Categories.ToList();
            return Ok(model);
        }
        [HttpPost]
        public IActionResult create(Category model)
        {
            _db.Categories. Add(model);
            _db.SaveChanges();
            return Ok("Created model");
        }
        [HttpPut]
        public IActionResult Edit(int id,Category model)
        {
            if (id==model.Id)
            {
                try
                {
                    _db.Categories.Update(model);
                    _db.SaveChanges();
                    return Ok("Updated model");
                }
                catch (Exception ex)
                {

                    return Ok (ex.Message);
                }
              
            }
            return BadRequest("Id not Found");
          
        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {

            if (id>0)
            {
                try
                {
                    _db.Categories.Remove(_db.Categories.Find(id));
                    _db.SaveChanges();
                    return Ok("Deleted model");
                }
                catch (Exception ex)
                {

                    return Ok(ex.Message);
                }

            }
            return BadRequest("Id not Found");
        }
    }
}
