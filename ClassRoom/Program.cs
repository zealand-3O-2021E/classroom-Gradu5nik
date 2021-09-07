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
            Student george = new Student("george",8,15);
            Console.WriteLine(george.Name);
            george.Name = "alex";
            Console.WriteLine(george.Name);

            Console.ReadKey();
        }
    }
}
