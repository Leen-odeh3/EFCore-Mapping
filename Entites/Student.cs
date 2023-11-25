using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Entites
{
    internal class Student
    {
        public int Id { get; set; }
        public string Fname { get; set; }
        public string Lastname { get; set; }
        public string Email{ get; set; }
        public string Address { get; set; }
        public int Age{ get; set; }
        public string Phone { get; set; }

    }
}
