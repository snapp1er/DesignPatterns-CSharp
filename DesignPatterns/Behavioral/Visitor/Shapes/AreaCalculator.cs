using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Visitor.Shapes
{
    class AreaCalculator : IShapeVisitor<float>
    {
        public float Visit(Circle circle)
        {
            return (float) (Math.Pow(circle.Radius, 2) * Math.PI);
        }

        public float Visit(Square square)
        {
            return (float)Math.Pow(square.Side, 2);
        }
    }
}
