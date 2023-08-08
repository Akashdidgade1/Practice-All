using AkshayMachineTest1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AkshayMachineTest1.Controllers
{
    public class InformationController : Controller
    {
        AppDbContext _db;

        public InformationController(AppDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View(_db.Information.ToList());
        }
        [HttpGet]
        public IActionResult Create()
        {
            InformationVm vm = new InformationVm()
            {
                Information = new Information(),
                CountryList = _db.country.ToList().Select(a => new SelectListItem()
                {
                    Text = a.Name,
                    Value = a.Name.ToString()
                }),
                Statelist=_db.states.ToList().Select(a=> new SelectListItem()
                {
                    Text = a.Name,
                    Value = a.Name.ToString()
                })
            };

            return View(vm);
        }
        [HttpPost]
        public IActionResult Create(InformationVm model)
        {
            if (model != null)
            {
                _db.Information.Add(model.Information);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
