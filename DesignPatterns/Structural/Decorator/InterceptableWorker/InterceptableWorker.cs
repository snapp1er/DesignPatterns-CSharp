using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural.Decorator.InterceptableWorker
{
    interface IWorker
    {
        void DoThis();
    }

    class Worker : IWorker
    {
        public void DoThis()
        {
            Console.WriteLine("Doing work...");
        }
    }

    class InterceptableWorker : IWorker
    {       
        public event Action BeforeWorkStarted;
        public event Action AfterWorkFinished;

        IWorker inner;
        public InterceptableWorker(IWorker inner)
        {
            this.inner = inner;
        }

        public static void Main(string[] args)
        {
            var interceptableWorker = new InterceptableWorker(new Worker());
            interceptableWorker.BeforeWorkStarted += () => { Console.WriteLine("Do this before start"); };
            //interceptableWorker.AfterWorkFinished += () => { Console.WriteLine("Do this after finish"); };
            interceptableWorker.DoThis();
        }

        
        public new void DoThis()
        {
            BeforeWorkStarted?.Invoke();
            inner.DoThis();
            AfterWorkFinished?.Invoke();
        }
    }
}
