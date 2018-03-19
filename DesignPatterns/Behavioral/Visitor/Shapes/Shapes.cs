using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DesignPatterns.Behavioral.Visitor.Shapes
{
    class Shapes
    {
        public static void Main(string[] args)
        {
            var circle = new Circle(10);
            
            Console.WriteLine($"Circle area: {circle.Accept(new AreaCalculator())}");
            /* Circle area: 314,1593 */

            var areaMeter = new AreaCalculator();
            float AreaOfSeveralSquares = Enumerable.Range(1, 3)
                                .Select(i => new Square(i))
                                .Sum(c => c.Accept(areaMeter));
            Console.WriteLine($"total area: {AreaOfSeveralSquares}");
            /* total area: 14 */

            
        }
    }
}
