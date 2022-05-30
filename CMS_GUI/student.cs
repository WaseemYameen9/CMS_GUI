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

        public student(string name, float marks, int rollno, int class_)
        {
            this.name = name;
            this.marks = marks;
            this.rollno = rollno;
            this.class_ = class_;
            this.attendedclasses = 0;
            this.fee = 0;
            this.duedate = "";
        }
        public student(string name, float marks, int rollno, int class_, float fee , int attendedclasses , string duedate)
        {
            this.name = name;
            this.marks = marks;
            this.rollno = rollno;
            this.class_ = class_;
            this.attendedclasses = attendedclasses;
            this.fee = fee;
            this.duedate = duedate;
        }

        public string getName()
        {
            return name;
        }

        public float getMarks()
        {
            return marks;
        }

        public int getRollno()
        {
            return rollno;
        }

        public int getclass_()
        {
            return class_;
        }

        public string getDuedate()
        {
            return duedate;
        }

        public float GetFee()
        {
            return fee;
        }

        public int getAttendedClasses()
        {
            return attendedclasses;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public void setMarks(float marks)
        {
            this.marks = marks;
        }

        public void setRollno(int rollno)
        {
            this.rollno = rollno;
        }

        public void setClass_(int class_)
        {
            this.class_ = class_;
        }

        public void setDuedate(string duedate)
        {
            this.duedate = duedate;
        }

        public void setFee(float fee)
        {
            this.fee = fee;
        }

        public void setAttendedClasses(int attendedclasses)
        {
            this.attendedclasses = attendedclasses;
        }

        public double getAttendencePercentage()
        {
            double attendencePercentage = (attendedclasses / 30.0) * 100.0;
            return attendencePercentage;
        }
    }
}
