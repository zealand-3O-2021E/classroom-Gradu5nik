using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace ClassRoom
{
    class ClassRoom
    {
        private string _className;
        private List<Student> _students;
        private DateTime _semesterStart;

        public ClassRoom()
        {
            Students = new List<Student>();
        }

        public string ClassName { get => _className; set => _className = value; }
        public DateTime SemesterStart { get => _semesterStart; set => _semesterStart = value; }
        internal List<Student> Students { get => _students; set => _students = value; }
        public void Seasons()
        {
            Console.WriteLine("out of our students");
            Console.WriteLine(Students.Where(x=>x.Season()=="Spring").Count()+" are born during spring");
            Console.WriteLine(Students.Where(x => x.Season() == "Summer").Count() + " are born during summer");
            Console.WriteLine(Students.Where(x => x.Season() == "Autumn").Count() + " are born during autumn");
            Console.WriteLine(Students.Where(x => x.Season() == "Winter").Count() + " are born during winter");
        }
    }
}
