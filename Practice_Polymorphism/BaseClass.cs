using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Practice_Polymorphism
{

    public class BaseClass
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public virtual double CalculateArea()
        {
            return Width * Height;
        }
    }

    public class Square : BaseClass
    {

    }

    public class Rectangle : BaseClass
    {

    }

    public class Triangle : BaseClass
    {
        public override double CalculateArea()
        {
            return Width * Height / 2;
        }
    }
}
