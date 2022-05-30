using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CMS_GUI
{
    class UserDL
    {
        private static List<User> userList = new List<User>();

        internal static List<User> UserList { get => userList; set => userList = value; }

        public static void AddIntoList(User s)
        {
            UserList.Add(s);
        }

        public static void StoreUserIntoFile()
        {
            string Path = "E:\\Semester 2\\OOP\\CMS_GUI\\User.txt";
            StreamWriter f = new StreamWriter(Path);
            foreach(User u in UserList)
            {
                f.WriteLine("{0},{1},{2}",u.getuserName(),u.getuserPassword(),u.getRole());
            }
            f.Flush();
            f.Close();
        }

        public static void LoadUser()
        {
            string Path = "E:\\Semester 2\\OOP\\CMS_GUI\\User.txt";
            StreamReader f = new StreamReader(Path);
            string record;
            while((record = f.ReadLine()) != null)
            {
                string[] splittedrecord = record.Split(',');
                string userName = splittedrecord[0];
                string userPassword = splittedrecord[1];
                string role = splittedrecord[2];
                if(role == "admin")
                {
                    admin u = new admin(userName, userPassword, "admin");
                    UserDL.AddIntoList(u);
                }
                else
                {
                    UserStudent u = new UserStudent(userName, userPassword, "student");
                    UserDL.AddIntoList(u);
                }
                
            }


        }

        public static bool isValid(string username)
        {
            
            for(int i = 0; i < username.Length; i++)
            {
                if (username[i] == '@')
                {
                    return true;
                }
                
            }
            return false;

        }
    }
}
