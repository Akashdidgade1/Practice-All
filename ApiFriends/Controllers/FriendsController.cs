using ApiFriends.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiFriends.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FriendsController : ControllerBase
    {
        AppDbContext _context;

        public FriendsController(AppDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult GetAllFriends()
        {
            var model = _context.Friends.ToList();
            return Ok(model);
        }
        [HttpGet]
        [Route("id")]
        public IActionResult GetAllFriendsById(int id)
        {
            var model = _context.Friends.FirstOrDefault(a=>a.Id==id);
            return Ok(model);
        }

    }
}
