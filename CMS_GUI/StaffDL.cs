using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
