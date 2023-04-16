using System;

namespace interfaceDemp
{
   interface IFigure
    {
        int Dimension { get; set; }
        double Area();
        double Perimeter();
    }

    class circle : IFigure
    {
        private int _dimension;
        public int Dimension
        {
            get { return _dimension; }
            set { _dimension = value; }
        }
        public double Area()
        {
            return Math.PI * _dimension;
        }
        public double Perimeter()
        {
            return Math.PI * 2 * _dimension;
        }
    }

    class square : IFigure
    {
        private int _dimension;
        public int Dimension
        {
            get { return _dimension; }
            set { _dimension = value; }
        }
        public double Area()
        {
            return _dimension * _dimension;
        }
        public double Perimeter()
        {
            return   4 * _dimension;
        }
    }
}
