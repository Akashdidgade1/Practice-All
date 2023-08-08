using Microsoft.AspNetCore.Mvc.Rendering;

namespace Institute.Models
{
    public class SchoolViewModel
    {
        public School School { get; set; }


        public IEnumerable<SelectListItem> Schoolname { get; set; }
        public IEnumerable<SelectListItem> Classname { get; set; }

    }
}
