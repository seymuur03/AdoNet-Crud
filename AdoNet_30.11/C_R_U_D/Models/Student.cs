using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace C_R_U_D.Models
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int GroupId { get; set; }
        public Group Group { get; set; }
        public List<StudentCourse> StudentCourses { get; set; } 

        public override string ToString()
        {
            return Id + " " + Name + " " + Age + " " + GroupId;
        }
    }
}
