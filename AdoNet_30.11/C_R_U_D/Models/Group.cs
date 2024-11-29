using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_R_U_D.Models
{
    internal class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Student> Students { get; set; }

        public override string ToString()
        {
            return Id + " " + Name;
        }
    }
}
