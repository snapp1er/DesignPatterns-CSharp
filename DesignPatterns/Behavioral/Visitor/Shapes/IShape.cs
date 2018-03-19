using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Visitor.Shapes
{
    interface IShape
    {
        string Name();
        T Accept<T>(IShapeVisitor<T> visitor);
    }
}
