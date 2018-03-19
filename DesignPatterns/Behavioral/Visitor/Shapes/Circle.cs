using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Visitor.Shapes
{
    class Circle : IShape
    {
        string name;
        float r;

        public float Radius {
            get { return r; }
        }

        public Circle(float r)
        {
            this.r = r;
            name = "circle";
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
