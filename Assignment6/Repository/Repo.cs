using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Assignment6.Models;

namespace Assignment6.Repository
{
    public class Repo
    {

        DataAccess.SchoolContext sContext = new DataAccess.SchoolContext();

        public IEnumerable<Student> GetAllStudents()
        {
            return sContext.Students;
        }

        public IEnumerable<Class> GetAllClasses()
        {
            return sContext.Classes;
        }

        public Student GetStudentDetails(int id)
        {
            return sContext.Students.FirstOrDefault(e => e.StudentID == id);
        }

        public Student AddStudent(Student student)
        {
            sContext.Students.Add(student);
            sContext.SaveChanges();

            return student;
        }
    }
}