using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidProjects.Classes
{
    public class Square
    {
        private int _a;
        public Square(int a)
        {
            _a = a;
        }

        public int Circumference()
        {
            return _a * 4;
        }

        public int Area()
        {
            return _a * _a;
        }
    }
}
