using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace PartyInvites.Models
{
    public class CompetitionInvite
    {
        public enum TechnicalInterest { Iot = 1, MotionSensors = 2, DataAnalytics = 3, Programming = 4 }

        [Required(ErrorMessage = "Please Enter Your Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please Enter Your Email Address")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Please Enter A Valid Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please Enter Your Home Address")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Please Enter Your Phone Number")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Please Specify Which Social Network Interest You Are Interested In")]
        public string SocialNetworkInterest { get; set; }

        [Required(ErrorMessage = "Please Specify Whether You'll Attend")]
        public bool WillAttend { get; set; }

        [Required(ErrorMessage = "Please Specify Which Technical Interest You Are Interested In")]
        public TechnicalInterest? Interest { get; set; }
    }


    public class GuestResponse
    {
        private static List<CompetitionInvite> responses = new List<CompetitionInvite>();

        public static IEnumerable<CompetitionInvite> UserResponses
        {
            get
            {
                return responses;
            }
        }

        public static void AddResponse(CompetitionInvite response)
        {
            responses.Add(response);
        }
    }
}
