using System;

namespace PolymorphismDemo
{
    public class shape
    {
        public virtual void Drawshape()
        {
            Console.WriteLine("drawing shape");
        }
    }

    public class circle : shape 
    { 
        public override void Drawshape()
        {
            Console.WriteLine("drawing circle");
        }
    }

}
