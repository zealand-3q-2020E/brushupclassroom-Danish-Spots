using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class ClassRoom
    {
        public ClassRoom()
        {
            ClassName = "";
            ClassList = new List<Student>();
            SemesterStart = new DateTime();
        }

        public string ClassName { get; set; }
        public List<Student> ClassList { get; set; }
        public DateTime SemesterStart { get; set; }
    }
}
