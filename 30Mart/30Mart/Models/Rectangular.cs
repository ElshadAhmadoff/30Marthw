using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31_03_2022_Homework.Models
{
    internal class Rectangular : Figure
    {
        private int _width;
        private int _length;
        public Rectangular(int width, int length)
        {
            Width = width;
            Length = length;
        }
        public int Width
        {
            get { return _width; }
            set
            {
                if (value > 0)
                {
                    _width = value;
                }
            }
        }
        public int Length
        {
            get { return _length; }
            set
            {
                if (value > 0) _length = value;
            }
        }

        public override int CalculateArea()
        {
            return Width * Length;
        }
    }
}