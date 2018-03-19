using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Visitor.Shapes
{
    interface IShapeVisitor<T>
    {
        T Visit(Circle circle);
        T Visit(Square square);
    }
}
