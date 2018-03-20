using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Observer.NumGenerator
{
    abstract class Observer
    {
        private NumGenerated _Update;
        public NumGenerated Update { get { return _Update; } }
        protected abstract NumGenerated InitUpdate();

        protected Observer()
        {
            _Update = InitUpdate();
        }
    }
}
