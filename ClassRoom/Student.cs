using System;
using System.Collections.Generic;
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
            _bMonth = bMonth;
            _bDay = bDay;
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
                    return "outside of timespace continium";
            }
        }
        public override string ToString()
        {
            return string.Format("{0}\tborn during {1} {2}.{3}", Name,Season(), BDay, BMonth);
        }
    }
}
