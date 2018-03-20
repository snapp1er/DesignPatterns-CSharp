using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Observer.NumGenerator
{
    delegate void NumGenerated(int num);

    class NumGenerator
    {
        event NumGenerated OnNumGenerated;
        private Random rand;

        public int GenerateNewInt()
        {
            int n = rand.Next(0, 1999);
            Console.WriteLine($"generated : {n}");
            OnNumGenerated(n);
            Console.WriteLine("=====================");
            return n;
        }

        public NumGenerator()
        {
            rand = new Random(1);
        }

        public void Attach(Observer obs)
        {
            OnNumGenerated += obs.Update;
        }

        public static void Main(string[] args)
        {
            var generator = new NumGenerator();
            generator.Attach(new EvenNumObserver());
            generator.Attach(new MoreThenThousandObserver());
            generator.Attach(new EndsWithThreeObserver());
            

            for(int i=0; i < 5; i++)
            {
                generator.GenerateNewInt();
            }
            
        }
    }
}
