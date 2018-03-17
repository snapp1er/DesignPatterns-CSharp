using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Chain_Of_Responsibility.ATM
{
    class MoneyGiver
    {
        MoneyGiver next;

        public void SetNext(MoneyGiver n)
        {
            next = n;
        }
        public void Add(MoneyGiver n)
        {
            if(next != null)
            {
                next.Add(n);
            }
            else
            {
                next = n;
            }
        }
        public virtual void Give(int sum) {
            if(next != null)
                next.Give(sum);
        }
    }
}
