using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using CMS_GUI;

namespace CMS_GUI
{
    class StaffDL
    {
        private static List<StaffBL> staffList = new List<StaffBL>();

        internal static List<StaffBL> StaffList { get => staffList; set => staffList = value; }

        public static void AddStaffIntoList(StaffBL s)
        {
            staffList.Add(s);
        }

        public static void storeStaffIntoFile()
        {
            StreamWriter f = new StreamWriter(Path.StaffPath);
            foreach(StaffBL s in staffList)
            {
                f.WriteLine("{0},{1},{2},{3}",s.Name,s.Department,s.Post,s.Salary);
            }
            f.Flush();
            f.Close();

        }

        public static void LoadStaffFormFile()
        {
            
            StreamReader f = new StreamReader(Path.StaffPath);
            string record;
            while ((record = f.ReadLine()) != null)
            {
                string[] splittedrecord = record.Split(',');
                string name = splittedrecord[0];
                string department = splittedrecord[1];
                string post = splittedrecord[2];
                float salary = float.Parse(splittedrecord[3]);

                StaffBL s = new StaffBL(name,department,post,salary);
                staffList.Add(s);

            }
            f.Close();
        }
    }
}
