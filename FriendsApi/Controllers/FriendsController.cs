using FriendsApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FriendsApi.Controllers
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

        public IActionResult GetAllFriends()
        {
          var model=  _context.Friends.ToList();
            return Ok(model);
        }


    }
}
