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
    }
}
