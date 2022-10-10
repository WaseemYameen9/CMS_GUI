using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_GUI
{
    class student
    {
        private string name;
        private float marks;
        private int rollno;
        private int class_;
        private int attendedclasses;
        private float fee;
        private string duedate;
        private double Percertage;

        public string Name { get => name; set => name = value; }
        public float Marks { get => marks; set => marks = value; }
        public int Rollno { get => rollno; set => rollno = value; }
        public int Class_ { get => class_; set => class_ = value; }
        public int Attendedclasses { get => attendedclasses; set => attendedclasses = value; }
        public string Duedate { get => duedate; set => duedate = value; }
        public double Percertage1 { get => Percertage; set => Percertage = value; }

        public student(string name, float marks, int rollno, int class_, float fee)
        {
            this.Name = name;
            this.Marks = marks;
            this.Rollno = rollno;
            this.Class_ = class_;
            this.Attendedclasses = 0;
            this.fee = 0;
            this.Duedate = "";
            this.fee = fee;
            Percertage1 = getMarksPercentage(marks);
        }
        public student(string name, float marks, int rollno, int class_, float fee , int attendedclasses , string duedate)
        {
            this.Name = name;
            this.Marks = marks;
            this.Rollno = rollno;
            this.Class_ = class_;
            this.Attendedclasses = attendedclasses;
            this.fee = fee;
            this.Duedate = duedate;
            Percertage1 = getMarksPercentage(marks);
        }

        public string getName()
        {
            return Name;
        }

        public float getMarks()
        {
            return Marks;
        }

        public int getRollno()
        {
            return Rollno;
        }

        public int getclass_()
        {
            return Class_;
        }

        public string getDuedate()
        {
            return Duedate;
        }

        public float GetFee()
        {
            return fee;
        }

        public int getAttendedClasses()
        {
            return Attendedclasses;
        }

        public void setName(string name)
        {
            this.Name = name;
        }

        public void setMarks(float marks)
        {
            this.Marks = marks;
        }

        public void setRollno(int rollno)
        {
            this.Rollno = rollno;
        }

        public void setClass_(int class_)
        {
            this.Class_ = class_;
        }

        public void setDuedate(string duedate)
        {
            this.Duedate = duedate;
        }

        public void setFee(float fee)
        {
            this.fee = fee;
        }

        public void setAttendedClasses(int attendedclasses)
        {
            this.Attendedclasses = attendedclasses;
        }

        public double getAttendencePercentage()
        {
            double attendencePercentage = (Attendedclasses / 30.0) * 100.0;
            return attendencePercentage;
        }

        public double getMarksPercentage(float marks)
        {
            double per = ((marks / 1100.0) * 100.0);
            return per;
        }
    }
}
