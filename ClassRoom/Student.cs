using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class Student
    {
        private string _name;
        private int _bMonth;
        private int _bDay;

        public Student(string name, int bMonth, int bDay)
        {
            

            
            _name = name;
            _bDay = bDay;
            Debug.Assert(bMonth > 0 && bMonth < 12,$"{name} cannot be born on {bMonth} month");
            _bMonth = bMonth;
            //try
            //{
            //    if (bMonth < 0 || bMonth > 12) throw (new ArgumentOutOfRangeException(""));
            //_bMonth = bMonth;
            //}
            //catch (ArgumentOutOfRangeException)
            //{
            //    Console.WriteLine($"Hey man, there is no {bMonth}th month, be serious, ok let's try again");
            //    Console.WriteLine($"So your name is {name}, birthday day is {bDay} and birthday month....");
            //    _bMonth = Convert.ToInt32(Console.ReadLine());



            //}
        }
        

        public string Name { get => _name; private set => _name = value; }
        public int BMonth { get => _bMonth; private set => _bMonth = value; }
        public int BDay { get => _bDay; private set => _bDay = value; }

        public string Season()
        {
            switch (0)
            {
                case 0 when BMonth > 2 && BMonth < 6:
                    return "Spring";
                case 0 when BMonth > 5 && BMonth < 9:
                    return "Summer";
                case 0 when BMonth > 8 && BMonth < 12:
                    return "Autumn";
                case 0 when BMonth == 12 || BMonth < 3:
                    return "Winter";
                default:
                    return "the outside of timespace continium";
            }
        }
        public override string ToString()
        {
            return string.Format("{0}\tborn during {1} {2}.{3}", Name,Season(), BDay, BMonth);
        }
    }
}
