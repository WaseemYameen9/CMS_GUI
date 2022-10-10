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
            
            StreamWriter f = new StreamWriter(Path.StudentPath);
            foreach(student s in studentList)
            {
                f.WriteLine("{0},{1},{2},{3},{4},{5},{6}",s.getName(), s.getMarks(), s.getRollno(), s.getclass_(), s.GetFee(),s.getAttendedClasses(),s.getDuedate()) ;
            }
            f.Flush();
            f.Close();
        }

        public static void LoadstudentsFromFile()
        {
            
            StreamReader f = new StreamReader(Path.StudentPath);
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
            f.Close();

        }

        public static bool DeleteStudentForm(string name)
        {
            for(int i = 0; i < studentList.Count; i++)
            {
                if(studentList[i].Name == name)
                {
                    studentList.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }

        public static student GetStudentObject(string name)
        {
            foreach(student s in studentList)
            {
                if(s.Name == name)
                {
                    return s;
                }
            }
            return null;
        }
    }
}
