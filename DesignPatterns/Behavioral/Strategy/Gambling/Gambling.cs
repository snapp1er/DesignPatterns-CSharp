using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Strategy.Gambling
{
    class Gambling
    {
        abstract class Strategy
        {
            public abstract int MakeMove();
        }
        class SafeStrategy : Strategy
        {
            Random rand = new Random(1);
            public override int MakeMove()
            {
                if (rand.Next(2) % 2 == 1)
                {
                    return 1;
                }
                else
                {
                    return -2;
                }
            }
        }
        class RiskyStrategy : Strategy
        {
            Random rand = new Random(1);
            public override int MakeMove()
            {
                if (rand.Next(3) % 3 == 0)
                {
                    return 30;
                }
                else
                {
                    return -10;
                }
            }
        }

        class Gambler
        {
            Strategy strategy;
            int money = 15;
            public int Money {get{return money;} }
            public Gambler(Strategy strategy)
            {
                this.strategy = strategy;
            }
            public void MakeMove()
            {
                Console.WriteLine("Making a move...");
                int res = strategy.MakeMove();
                money += res;
                Console.WriteLine("Result: {0}", res);
                Console.WriteLine("Current money: {0}", money);
            }
            public void SetStrategy(Strategy strategy)
            {
                this.strategy = strategy;
            }
        }

        public static void Main(string[] args)
        {
            var gamer = new Gambler(new SafeStrategy());
            while(gamer.Money > 10)
            {
                gamer.MakeMove();
            }
            Console.WriteLine("Changing strategy to risky one...");
            gamer.SetStrategy(new RiskyStrategy());
            gamer.MakeMove();
            /*
            Making a move...
            Result: -2
            Current money: 13
            Making a move...
            Result: -2
            Current money: 11
            Making a move...
            Result: -2
            Current money: 9
            Changing strategy to risky one...
            Making a move...
            Result: 30
            Current money: 39
            */
        }
    }
}
