using Project1_Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1_Logic.Roles
{
    class Registrar_Logic : Professor_Logic
    {
        public static void RegistrarAddCourse(cours c)
        {
            using (var ef = new baron_project1Entities())
            {
                ef.courses.Add(new cours { courseDepartment = c.courseDepartment, courseName = c.courseName, courseNumber = c.courseNumber, courseEnrollment = c.courseEnrollment,courseTime=c.courseTime, courseDate=c.courseDate,professorID=c.professorID });
                ef.SaveChanges();
            }
        }

        //public static void RegistarAddTimeToCourse(courseDateTime t)
        //{
        //    using (var ef = new baron_project1Entities())
        //    {
        //        ef.courses.Add(new courseDateTime { courseDate1 = t.courseDate1, courseDate2 = t.courseDate2, courseDate3 = t.courseDate3, courseDate4 = t.courseDate4, courseDate5 = t.courseDate5, courseTime=t.courseTime });
        //        ef.SaveChanges();
        //    }

        //}

    }
}
