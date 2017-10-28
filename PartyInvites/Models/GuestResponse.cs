using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

/// <summary>
/// In models we typicall createa are field declarative variables with getter and setters.
/// Here we also add are validation constraints to each property
/// </summary>
namespace PartyInvites.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage = "Please Enter Your Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please Enter Your Email Address")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Please Enter A Valid Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please Enter Your Phone Number")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Please Specify Whether You'll Attend")]
        public bool? WillAttend { get; set; }
    }
}
