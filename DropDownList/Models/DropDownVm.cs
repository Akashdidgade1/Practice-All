using Microsoft.AspNetCore.Mvc.Rendering;

namespace DropDownList.Models
{
    public class DropDownVm
    {
        public InformationSample InformationSample { get; set; }
        public IEnumerable<SelectListItem> satelist { get; set; }
    }
}
