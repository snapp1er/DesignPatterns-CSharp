using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DesignPatterns.Structural.Composite.Holders
{
    public static class ForEachExtenstion
    {
        public static void ForEach<T>(this IEnumerable<T> source, Action<T> action)
        {
            foreach (var item in source)
            {
                action(item);
            }
        }
    }

    class Battery : WeighableObject
    {
        public Battery() : base(0.05f) { }
    }
    class Bottle : WeighableObject
    {
        public Bottle() : base(0.5f) { }
    }
    class Tent : WeighableObject
    {
        public Tent() : base(1f) { }
    }

    class Backpack : WeighableHolder
    {
        public Backpack() : base(0.5f) {}
    }

    class Handbag : WeighableHolder
    {
        public Handbag() : base(0.25f) { }
    }

    class Holders
    {       
        
        public static void Main(string[] args)
        {
            var backpack = new Backpack();
            var handbag = new Handbag();
            
            Enumerable.Range(0, 3)
                        .ForEach(i => handbag.Add(new Bottle()));

            for(int i=0; i<10; i++)
            {
                handbag.Add(new Battery());
            }

            Enumerable.Range(0, 10).ToList()
                .ForEach(x => backpack.Add(new Bottle()));

            backpack.Add(new Tent());
            backpack.Add(handbag);

            Console.WriteLine($"Backpack's weight: {backpack.GetWeight()}");
            Console.WriteLine($"Handbag's weight: {handbag.GetWeight()}");
            /*
            Backpack's weight: 8,75
            Handbag's weight: 2,25
            */

        }
    }
}
