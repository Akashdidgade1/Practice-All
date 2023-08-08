using Friends.web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Friends.web.Controllers
{
    public class FriendsController : Controller
    {
        AppDbContext _db;
        IWebHostEnvironment _Iweb;

        public FriendsController(AppDbContext db, IWebHostEnvironment iweb)
        {
            _db = db;
            _Iweb = iweb;
        }

        public IActionResult Index()
        {
            return View(_db.Friends.ToList());
        }

        public IActionResult Create()
        {

            Friend model = new Friend()
            {
                citylist = _db.Cities.ToList().Select(a => new SelectListItem()
                {
                    Text = a.Name,
                    Value = a.Name.ToString()
                })
            };
            return View(model);
        }
        [HttpPost]
        public IActionResult Create(Friend model, IFormFile? file)
        {

            string WwwRooPath = _Iweb.WebRootPath.ToString();
            if (model != null)
            {
                string Filename = Guid.NewGuid().ToString();
                var uploads = Path.Combine(WwwRooPath, @"Image");
                var Extension = Path.GetExtension(file.FileName);
                using (var filestream = new FileStream(Path.Combine(uploads, Filename + Extension), FileMode.Create))
                {
                    file.CopyTo(filestream);
                }
                model.Image = Filename + Extension;
                _db.Friends.Add(model);
                _db.SaveChanges();

                TempData["Messsage"] = "Record inserted Succesfully";
                return RedirectToAction("Index");
            }

            return View();
        }
 
        public IActionResult Delete(int id)
        {
            if (id>=0)
            {
                _db.Friends.Remove(_db.Friends.Find(id));
                return RedirectToAction("Index");

            }
          

            return View();
        }
    }
}
