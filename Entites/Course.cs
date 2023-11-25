using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Entites
{
    internal class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int NumberofStudent { get; set; }

        public string InstructorName { get; set; }

    }
}
