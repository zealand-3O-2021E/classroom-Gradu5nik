using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassRoom csClass = new ClassRoom() { ClassName = "3Q", SemesterStart=new DateTime(2019,8,26),  };
            Student george = new Student("george",8,15);
            Student Toni = new Student("Toni", 9, 3);
            Student Thibo = new Student("Thibo", 3, 18);
            csClass.Students.Add(george);
            csClass.Students.Add(Toni);
            csClass.Students.Add(Thibo);
            foreach (Student st in csClass.Students)
            {
                Console.WriteLine(st);
            }
            Console.ReadKey();
        }
    }
}
