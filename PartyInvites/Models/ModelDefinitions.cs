using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace PartyInvites.Models
{
    public class GuestInfo
    {
        public enum TechnicalInterest { Iot = 1, MotionSensors = 2, DataAnalytics = 3, Programming = 4 }
        public TechnicalInterest Interest { get; set; }

        [Required(ErrorMessage = "Please Enter Your Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please Enter Your Email Address")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Please Enter A Valid Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please Enter Your Phone Number")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Please Enter Your Address")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Please Specify which interest you are interested in")]
        public string SocialNetworkInterest { get; set; }

        [Required(ErrorMessage = "Please Specify Whether You'll Attend")]
        public bool? WillAttend { get; set; }
    }
   

    public class GuestResponse
    {
        private static List<GuestInfo> responses = new List<GuestInfo>();

        public static IEnumerable<GuestInfo> UserResponses
        {
            get
            {
                return responses;
            }
        }

        public static void AddResponse(GuestInfo response)
        {
            responses.Add(response);
        }
    }
}
