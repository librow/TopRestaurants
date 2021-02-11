using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TopRestaurants.Models
{
    public class Suggestion
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string RestName { get; set; }
        //nullable allows next two variables to be null
#nullable enable
        public string? FavDish { get; set; }
        //validates that numbers entered are a valid phone number
        [Required][Phone]
        [RegularExpression(@"^[1-9]\d{2}-\d{3}-\d{4}$", ErrorMessage = "Please return a phone number in this format: ###-###-####")] 
        public string? PhoneNum { get; set; }
    }
}
