using Project1_Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1_Logic.Roles
{
    class Student_Logic
    {

        public static void AddStudentToCourse(student s, cours c)
        {
            using (var ef = new baron_project1Entities())
            {
                ef.studentCourseLists.Add(new studentCourseList{studentID=s.studentID, courseID=c.courseID});
                ef.SaveChanges();

            }

        }

        public static void RemoveStudentFromCourse(student s, cours c)
        {
            using (var ef = new baron_project1Entities())
            {
                ef.studentCourseLists.Remove(new studentCourseList { studentID = s.studentID, courseID = c.courseID });
                ef.SaveChanges();

            }
        }

        public static void ViewStudentSchedule(student s, cours c)
        {
            using (var ef = new baron_project1Entities())
            {

               var course = ef.studentCourseLists.Find(s.studentID);
               var schedule = ef.courses.Find(course.courseID);

            }
        }


    }
}
