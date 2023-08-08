using DropDownList.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DropDownList.Controllers
{
    public class DropDownController : Controller
    {
        AppDbContext _db;

        public DropDownController(AppDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View(_db.InformationSamples.ToList());
        }
        [HttpGet]
        public IActionResult Create()
        {
            DropDownVm model = new DropDownVm()
            {
                InformationSample = new InformationSample(),

                satelist = _db.StateSamples.ToList().Select(a=> new SelectListItem()
                {
                    Text= a.Name,
                    Value= a.Id.ToString()
                })
            };

            return View(model);
        }
        [HttpPost]
        public IActionResult Create(DropDownVm model)
        {
            if (ModelState.IsValid)
            {
                _db.InformationSamples.Add(model.InformationSample);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View();
        }
    }
}
