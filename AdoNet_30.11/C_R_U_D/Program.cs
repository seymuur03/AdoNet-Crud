using C_R_U_D.Services;
using C_R_U_D.Models;

namespace C_R_U_D
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            GroupServices groupService = new GroupServices();
            #region Create and Read Datas for Group :
            //groupService.CreateGroup(new() { Name = "PB502"});
            //groupService.CreateGroup(new() { Name = "PN101" });

            //foreach (var group in groupService.GetAllGroup())
            //{
            //    Console.WriteLine(group);
            //}
            #endregion

            StudentServices studentService = new StudentServices();
            #region Create and Read Datas for Student :
            //studentService.StudentCreate(new() { Name = "Seymur",Age = 19 , GroupId = 1});
            //studentService.StudentCreate(new() { Name = "Lorem", Age = 22, GroupId = 1 });
            //studentService.StudentCreate(new() { Name = "Ipsum", Age = 20, GroupId = 2 });
            //studentService.StudentCreate(new() { Name = "Filankes", Age = 18, GroupId = 2 });

            //foreach (var student in studentService.GetAllStudent())
            //{
            //    Console.WriteLine(student);
            //}
            #endregion

            StudentDetailServices studentDetailService = new StudentDetailServices();
            #region Create and Read Datas for StudentDetail :
            //studentDetailService.StuDetailsCreate(new() { Adress = "Gandja" , PhoneNumber = "+994558429775", StudentId = 1 });
            //studentDetailService.StuDetailsCreate(new() { Adress = "Baku", PhoneNumber = "+994558568924", StudentId = 2 });
            //studentDetailService.StuDetailsCreate(new() { Adress = "Sumqayit", PhoneNumber = "+994558412685", StudentId = 3 });
            //studentDetailService.StuDetailsCreate(new() { Adress = "Lacin", PhoneNumber = "+994502639775", StudentId = 4 });

            //foreach (var student in studentDetailService.GetAllStuDetail())
            //{
            //    Console.WriteLine(student);
            //}
            #endregion

            CourseServices courseService = new CourseServices();
            #region Create and Read Datas for StudentDetail :
            //courseService.CreateCourse(new() {Name = "CodeAcademy" });
            //courseService.CreateCourse(new() { Name = "DivAcademy" });

            //foreach (var course in courseService.GetAllCourse())
            //{
            //    Console.WriteLine(course);
            //}
            #endregion

            StudentCourseServices studentCourseService = new StudentCourseServices();
            #region Create and Read Datas for StudentCourse :
            //studentCourseService.CreateStudentCourse(new() { StudentId = 1 , CourseId = 1 });
            //studentCourseService.CreateStudentCourse(new() { StudentId = 2, CourseId = 1 });
            //studentCourseService.CreateStudentCourse(new() { StudentId = 3, CourseId = 1 });
            //studentCourseService.CreateStudentCourse(new() { StudentId = 2, CourseId = 2 });
            //studentCourseService.CreateStudentCourse(new() { StudentId = 4, CourseId = 2 });

            //foreach (var studentCourse in studentCourseService.GetAllStuCourse())
            //{
            //    Console.WriteLine(studentCourse);
            //}
            #endregion

            OneToOneRelationServices relation1 = new OneToOneRelationServices();
            #region OneToOne releation : Student and StudentDetail :
            //relation1.GetAllStudentWithDetails();
            //relation1.Update(20,30);

            //studentService.Update(20,30);
            studentDetailService.Update(20, 30);
            #endregion
        }
    }
}
