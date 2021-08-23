using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1
{
   public  enum Price
    {
        Cheap,
        Affordable,
        Expensive
    }
    public class Review
    {
        public Guid IdReview { get; set; }
        public float Note { get; set; }
        public Price CostOfPlace { get; set; }
       
        public string Place { get; set; }
        public User User { get; set; }
        public bool CheckUser(User user)
        {
            return (User == user);
           

        }
        public Review(float note, Price costofplace)
        {
            
            IdReview = new Guid();
            Note = note;
            CostOfPlace = costofplace;
            
        }
        public Review(float note, Price costofplace, User user) : this(note, costofplace)
        {
            User = user;
        }
        public override string ToString()
        {
            return $"Name:{Place}::{Note}";
        }
        // a list of photo

    }
}
