using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_GUI
{
    class StaffBL
    {
        private string name;
        private string department;
        private string post;
        private float salary;


        public StaffBL(string name,string department,string post,float salary)
        {
            this.name = name;
            this.department = department;
            this.post = post;
            this.salary = salary;
        }

        public string Name { get => name; set => name = value; }
        public string Department { get => department; set => department = value; }
        public string Post { get => post; set => post = value; }
        public float Salary { get => salary; set => salary = value; }

    }
}
