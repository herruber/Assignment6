namespace Assignment6.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Assignment6.Models;
    using System.Collections.Generic;

    internal sealed class Configuration : DbMigrationsConfiguration<Assignment6.DataAccess.SchoolContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Assignment6.DataAccess.SchoolContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            Teacher teacher = new Teacher { TeacherID=1, Name="Arne Weise", Classes=new List<Class>() };
            Class classe = new Class { ClassID=1, ClassName="8A", Teachers= new List<Teacher>() };
            Student student = new Student {StudentID=1, StudentName="Eva Gulbrun", ClassID=1};
            classe.Teachers.Add(teacher);

            context.Classes.AddOrUpdate(e => e.ClassID, classe);
            context.Students.AddOrUpdate(e => e.StudentID, student);

            context.SaveChanges();
        }
    }
}
