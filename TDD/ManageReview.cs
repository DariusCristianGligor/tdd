using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1
{
    class ManageReview
    {
        public Review Review { set; get; }

        public bool CanBeDeletedUser user)
        {
            return ((user == Review.User) || (user.IsAdmin == true));
        
        }

    }
}
