using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Observer.NumGenerator
{
    class MoreThenThousandObserver : Observer
    {
        protected override NumGenerated InitUpdate()
        {
            return (n) => { if (n > 1000) Console.WriteLine("Number is more than thousand"); };
        }
    }

    class EndsWithThreeObserver : Observer
    {
        protected override NumGenerated InitUpdate()
        {
            return (n) => { if (n % 10 == 3) Console.WriteLine("Number ends with three"); };
        }
    }

    class EvenNumObserver : Observer
    {
        protected override NumGenerated InitUpdate()
        {
            return UpdateMethod;
        }

        public void UpdateMethod(int n)
        {
            //Console.WriteLine("in UpdateMethod : {0}", n);
            if( n % 2 == 0)
            {
                Console.WriteLine("Number is even");
            }
        }
    }
}
