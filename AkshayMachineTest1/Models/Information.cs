using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AkshayMachineTest1.Models
{
    public class Information
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [Range(18, 100, ErrorMessage = "Age Should be in between 18-100")]
        public int age { get; set; }
       
        public string Gender { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [Phone]
        public string PhoneNumber { get; set; }
        public string Country { get;set; }
        public string State { get; set; }
        [NotMapped]
        public string Image { get; set; }

        [NotMapped]
        public IEnumerable<SelectListItem> Countrylist { get; set; }
    }
}
