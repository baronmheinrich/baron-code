using Project1_Database;
using Project1_Logic;
using System;
using Xunit;



namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            student student = new student();
            cours course = new cours();

            student.studentID = 0;
            student.studentFirst = "Orpolar";
            student.studentLast = "Baraknowska";


            course.courseID = 0;
            course.courseName = "Algebra 1";
            course.courseDepartment = "Math";
            course.courseNumber = "MATH-1001";
            course.courseCapacity = 25;
            course.courseEnrollment = 10;
            course.courseTime = 1000;
            course.courseDate = 0;
            course.professorID = 1;

            AddStudentToCourse();
        }

    }



    
}
