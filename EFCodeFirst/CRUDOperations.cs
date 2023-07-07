using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirst
{
    internal class CRUDOperations
    {
        public void InsertRecordsInCourseEntity()
        {
            using (var context = new College_Context())
            {
                var cour = new Course()
                {
                    Course_Id = 101,
                    Course_Name = "MCA"
                };

                context.Courses.Add(cour);
                context.SaveChanges();

            }
        }
        public void InsertRecordsInStudentEntity()
        {
            using (var context = new College_Context())
            {
                var stud = new Student()
                {
                    Student_Id = 1,
                    Student_Name = "abi"
                };

                context.Students.Add(stud);
                context.SaveChanges();

            }

        }
        public void UpdateRecordsInStudentEntity()
        {
            using (var context = new College_Context()) 
            {
             var st_1 = context.Students.First<Student>(s =>(s.Student_Id==1));
                st_1.Student_Age = 15;
                context.SaveChanges();
            }
        }
        public void DeleteRecordsInStudentEntity()
        {
            using (var context = new College_Context())
            {
                var st=context.Students.First<Student>();
                context.Students.Remove(st);
                context.SaveChanges();
            }
        } 

        public void ReadDataFromStudentEntity(string st_name)
        {
            using (var context = new College_Context())
            {
                var st= context.Students.Where(s => s.Student_Name==st_name);
                Console.WriteLine(st_name);
            }
        }
    }
}
