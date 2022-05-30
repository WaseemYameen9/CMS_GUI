using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CMS_GUI
{
    class StudentDL
    {
        private static List<student> studentList = new List<student>();

        internal static List<student> StudentList { get => studentList; set => studentList = value; }

        public static void AddStudentintoList(student s)
        {
            studentList.Add(s);
        }

        public static void storeStudentIntoFile()
        {


        }

        public static void LoadFromFile()
        {

        }

        public static bool EnterAttendence(string name , int attendedClasses)
        {
            foreach(student s in studentList)
            {
                if (s.getName() == name)
                {
                    s.setAttendedClasses(attendedClasses);
                    return true;
                }
            }
            return false;
        }

        public static bool AddFee(string name , float fee, string duedate)
        {
            foreach(student s in studentList)
            {
                if(s.getName() == name)
                {
                    s.setFee(fee);
                    s.setDuedate(duedate);
                    return true;
                }
            }
            return false;
        }

        public static void StoreStudentIntoFile()
        {
            string path = "E:\\Semester 2\\OOP\\CMS_GUI\\student.txt";
            StreamWriter f = new StreamWriter(path , true);
            foreach(student s in studentList)
            {
                f.WriteLine(s.getName(), s.getMarks(), s.getRollno(), s.getclass_(), s.GetFee(),s.getAttendedClasses(),s.getDuedate()) ;
            }
            f.Flush();
            f.Close();
        }

        public static void LoadstudentsFromFile()
        {
            string path = "E:\\Semester 2\\OOP\\CMS_GUI\\student.txt";
            StreamReader f = new StreamReader(path);
            string record;
            while((record = f.ReadLine()) != null)
            {
                string[] splittedrecord = record.Split(',');
                string name = splittedrecord[0];
                float marks = float.Parse(splittedrecord[1]);
                int rollno = int.Parse(splittedrecord[2]);
                int class_ = int.Parse(splittedrecord[3]);
                float fee = float.Parse(splittedrecord[4]);
                int attendedclasses = int.Parse(splittedrecord[5]);
                string duedate = splittedrecord[6];

                student s = new student(name,marks,rollno,class_,fee,attendedclasses,duedate);
                studentList.Add(s);

            }
        }
    }
}
