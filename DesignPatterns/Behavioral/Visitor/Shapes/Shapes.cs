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

            //===============
            var list = new List<IShape>();
            list.Add(new Circle(10));
            list.Add(new Circle(10));
            list.Add(new Square(10));


            foreach(var s in list)
            {
                Console.WriteLine($"Shape[{s.Name()}] has area of {s.Accept(areaMeter)}");
            }

            /*
               Shape[circle] has area of 314,1593
               Shape[circle] has area of 314,1593
               Shape[Square] has area of 100
            */


        }
    }
}
