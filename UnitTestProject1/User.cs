using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1
{
    interface IUser {
        bool IsAdmin();
    }
    public class User:IUser
    { 
    public Guid IdUser { get; set; }
    public string Name { set; get; }
    public string Mail { set; get; }
    public string Address { set; get; }
    private bool _isAdmin { set; get; }
    public string Password { set; get; }

    

    public User(string name, string mail, string adrress, string password,bool isAdmin)
    {
        Password = password;
        Name = name;
        IdUser = new Guid();
        Mail = mail;
        Address = adrress;
        _isAdmin = isAdmin;
    }
        public virtual bool IsAdmin()
        {
            return _isAdmin;
        }

       

        public override string ToString()
    {
        return $"Name:{Name} :: mail :{Mail} :: {Address}";
    }
}
}
