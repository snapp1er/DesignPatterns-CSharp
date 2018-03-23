using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Template_Method.Workers
{
    class Workers
    {
        abstract class Worker
        {
            protected string Name;
            public Worker(string name)
            {
                this.Name = name;
            }
            public void WorkDay()
            {
                GetUp();
                EatBreakfast();
                Work();
                Sleep();
            }

            public void GetUp()
            {
                Console.WriteLine("{0} got up", Name);
            }
            public void Sleep()
            {
                Console.WriteLine("{0} went to sleep", Name);
            }
            public abstract void EatBreakfast();
            public abstract void Work();
        }
        class Programmer : Worker
        {
            public Programmer(string name) : base(name) { }
            public override void EatBreakfast()
            {
                Console.WriteLine("{0} eating Eggs for breakfast", Name);
            }
            public override void Work()
            {
                Console.WriteLine("{0} is coding all day", Name);
            }
        }

        class Designer : Worker
        {
            public Designer(string name) : base(name) { }
            public override void EatBreakfast()
            {
                Console.WriteLine("{0} eating porridge for breakfast", Name);
            }

            public override void Work()
            {
                Console.WriteLine("{0} designing UI all day", Name);
            }
        }

        public static void Main(string[] args)
        {
            var programmer = new Programmer("Eddy");
            var designer = new Designer("Kyle");

            programmer.WorkDay();
            designer.WorkDay();
        }
        /*
        Eddy got up
        Eddy eating Eggs for breakfast
        Eddy is coding all day
        Eddy went to sleep
        Kyle got up
        Kyle eating porridge for breakfast
        Kyle designing UI all day
        Kyle went to sleep
        */
    }
}
