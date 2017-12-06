using Project1_Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1_Logic.Roles
{
    class Professor_Logic : Student_Logic
    {

        public static void ViewProfessorCourseList(professor p)
        {
            using (var ef = new baron_project1Entities())
            {

                var course = ef.studentCourseLists.Find(p.professorID);
                var schedule = ef.courses.Find(course.courseID);

            }
        }

    }
}
