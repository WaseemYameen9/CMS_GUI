using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_GUI
{
    class UserStudent : User
    {

        private string role;

        public UserStudent(string userName, string userPassword, string role) : base(userName, userPassword)
        {
            this.role = role;
        }

        public override string getRole()
        {
            return role;
        }

        public void setRole(string role)
        {
            this.role = role;
        }

    }
}
