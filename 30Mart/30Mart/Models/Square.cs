using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31_03_2022_Homework.Models
{
    internal class Square : Figure
    {
        private int _side;
        public Square(int side)
        {
            Side = side;
        }
        public int Side
        {
            get { return _side; }
            set
            {
                if (value > 0) _side = value;
            }
        }

        public override int CalculateArea()
        {
            return Side * Side;
        }
    }
}