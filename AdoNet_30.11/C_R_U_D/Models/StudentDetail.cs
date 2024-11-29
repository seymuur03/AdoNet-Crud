using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_R_U_D.Models
{
    internal class StudentDetail
    {
        public int Id { get; set; }
        public string Adress { get; set; }
        public string PhoneNumber { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; } 

        public override string ToString()
        {
            return Id + " " + Adress + " " + PhoneNumber + " " + StudentId;
        }
    }
}
