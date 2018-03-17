using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Chain_Of_Responsibility.ATM
{
    class CustomMoneyGiver : MoneyGiver
    {
        private int value;

        public CustomMoneyGiver(int sum)
        {
            value = sum;
        }

        public override void Give(int sum)
        {
            int n = sum / value;
            if(n > 0)
            {
                Console.WriteLine("Giving out {0} notes by {1}", n, value);
                sum -= n * value;
            }
            base.Give(sum);
        }
    }
}
