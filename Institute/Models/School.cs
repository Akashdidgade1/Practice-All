using Microsoft.AspNetCore.Mvc.Rendering;

namespace Institute.Models
{
    public class School
    {
        public int Id { get; set; }
        public string SchoolName { get; set; }
        public string Class { get; set; }
        public int DisplayOrderNumber { get; set; }

        public IEnumerable<SelectListItem> Schoolname { get; set; }
        public IEnumerable<SelectListItem> Classname { get; set; }
    }
}
