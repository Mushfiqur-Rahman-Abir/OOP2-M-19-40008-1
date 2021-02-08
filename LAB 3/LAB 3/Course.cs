using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_3
{
    class Course
    {
        string courseName;
        string courseCode;
        int courseCredit;

        public string CourseName
        {
            set { courseName = value; }
            get { return courseName; }
        }
        public string CourseCode
        {
            set { courseCode = value; }
            get { return courseCode; }
        }
        public int CourseCredit
        {
            set { courseCredit = value; }
            get { return courseCredit; }
        }

        public Course()
        {
            Console.WriteLine("Course Created with default.");
        }

        public Course(string courseName, string courseCode, int courseCredit)
        {
            Console.WriteLine("Course Created with 3 parameters.");
            this.courseName = courseName;
            this.courseCode = courseCode;
            this.courseCredit = courseCredit;
        }

        public void ShowInfo()
        {
            Console.WriteLine("Course Name is: " + courseName);
            Console.WriteLine("Course Code is: " + CourseCode);
            Console.WriteLine("Course credit is: " + courseCredit);
        }
    }
}
