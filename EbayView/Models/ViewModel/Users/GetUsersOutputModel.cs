using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EbayView.Models.ViewModel.Users
{
    public class GetUsersOutputModel
    {
        public int UserId { get; set; }
        public string FistName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }

    }
}
