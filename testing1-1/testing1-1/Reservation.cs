using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing
{
   public class Reservation
    {
        public User MadeBy { set; get; }

        public bool CanBeCancelledBy(User user)
        {
           return ( user.IsAdmin  || MadeBy == user );
           
        }
    }
    public class User
    {
        public bool IsAdmin { get; set; }
    }
}
