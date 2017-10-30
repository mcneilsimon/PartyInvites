using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartyInvites.Models
{
    public class ViewModel
    {
        public IEnumerable<GuestInfo> GuestInfo { get; set; }
        public IEnumerable<GuestResponse> GuestResponse { get; set; }
    }
}
