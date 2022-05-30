using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_GUI
{
    class User
    {
        protected string userName;
        protected string userPassword;

        public User(string userName, string userPassword)
        {
            this.userName = userName;
            this.userPassword = userPassword;
        }

        public string getuserName()
        {
            return userName;
        }

        public string getuserPassword()
        {
            return userPassword;
        }
        public virtual string getRole()
        {
            return "undefined";
        }

       
    }
}
