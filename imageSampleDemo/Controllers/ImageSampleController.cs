using imageSampleDemo.Models;
using Microsoft.AspNetCore.Mvc;

namespace imageSampleDemo.Controllers
{
    public class ImageSampleController : Controller
    {
        AppDbContext _db;
       private readonly IWebHostEnvironment _webHost;

        public ImageSampleController(AppDbContext db, IWebHostEnvironment webHost)
        {
            _db = db;
            _webHost = webHost;
        }

        public IActionResult Index()
        {
            return View(_db.SampleImages.ToList());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(SampleImage model, IFormFile? file)
        {
            if (ModelState.IsValid)
            {
                string WwwRootPath = _webHost.WebRootPath.ToString();
                if (file != null)
                {
                    string FileName = Guid.NewGuid().ToString();
                    var uploads = Path.Combine(WwwRootPath, @"Image");
                    var Extension = Path.GetExtension(file.FileName);
                    using (var fileStream = new FileStream(Path.Combine(uploads, FileName + Extension), FileMode.Create))
                    {
                        file.CopyTo(fileStream);
                    }

                    model.Image = FileName + Extension;
                }


              //  return View();
                _db.SampleImages.Add(model);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

    }
}
