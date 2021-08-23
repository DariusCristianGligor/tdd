using Moq;
using System;

namespace UnitTestProject1
{
    public class ManagerReview
    { 
        public ManagerReview()
        {
        }
        public Review Review { set; get; }

        public virtual bool CanBeDeletedUser(User user)
        {
            return ((user == Review.User) || (user.IsAdmin() == true));
        }

       
    }
    }
        
 