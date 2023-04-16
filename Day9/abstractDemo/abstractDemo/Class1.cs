namespace abstractDemo
{
    abstract class figure
    {
        public int dimension;
        public abstract double Area();
        public abstract double Perimeter();
    }
    class square : figure
    {
        public override double Area()
        {
            return dimension*dimension ;
        }
        public override double Perimeter()
        {
            return 4*dimension ;
        }
    }
    class circle : figure
    {
        public override double Area()
        {
            return 3.14*dimension*dimension;
        }
        public override double Perimeter()
        {
            return 2*3.14*dimension;
        }
    }
}
