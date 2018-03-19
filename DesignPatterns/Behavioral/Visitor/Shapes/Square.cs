using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Visitor.Shapes
{
    class Square : IShape
    {
        string name;
        float side;

        public float Side { get { return side; } }

        public Square(float side)
        {
            this.side = side;
            name = "Square";
        }
        public string Name()
        {
            return name;
        }

        public T Accept<T>(IShapeVisitor<T> visitor)
        {
            return visitor.Visit(this);
        }
    }
}
