using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AkshayMachineTest1.Models
{
    public class InformationVm
    {
        public Information Information { get; set; }
        [ValidateNever]
        public IEnumerable<SelectListItem> CountryList { get;set; }
        [ValidateNever]
        public IEnumerable<SelectListItem> Statelist { get; set; }

    }
}
