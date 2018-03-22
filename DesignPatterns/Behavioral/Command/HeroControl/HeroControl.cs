using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Command.HeroControl
{
    class HeroControl
    {
        interface ICommand
        {
            void Execute(IHero hero);
        }
        class HealCommand : ICommand
        {
            int hp;
            public HealCommand(int hp)
            {
                this.hp = hp;
            }            
            public void Execute(IHero hero)
            {
                hero.Heal(hp);
            }
        }
        class DamageCommand : ICommand
        {
            int dmg;
            public DamageCommand(int dmg)
            {
                this.dmg = dmg;
            }
            public void Execute(IHero hero)
            {
                hero.TakeDamage(dmg);
            }
        }

        interface IHero
        {
            void Heal(int hp);
            void TakeDamage(int hp);
        }
        class Hero : IHero
        {
            private int health;

            public Hero()
            {
                health = 100;
            }
            public void Heal(int hp)
            {
                health += hp;
                health = Math.Min(100, health);
                Console.WriteLine("Healing by {0} hp", hp);
            }

            public void TakeDamage(int hp)
            {
                health -= hp;
                Console.WriteLine("Taking {0} damage", hp);
            }

            public void ConsumeCommand(ICommand cmd)
            {
                cmd.Execute(this);
            }

            public int CurrentHealth()
            { return health; }
        }

        public static void Main(string[] args)
        {
            var hero = new Hero();
            var littleHeal = new HealCommand(10);
            var bigHeal = new HealCommand(50);
            var dmg = new DamageCommand(20);

            var queue = new Queue<ICommand>();
            queue.Enqueue(dmg);
            queue.Enqueue(littleHeal);
            queue.Enqueue(dmg);
            queue.Enqueue(bigHeal);

            foreach(var cmd in queue)
            {
                hero.ConsumeCommand(cmd);
                Console.WriteLine("Current health: {0}", hero.CurrentHealth());
            }
            /*
            Taking 20 damage
            Current health: 80
            Healing by 10 hp
            Current health: 90
            Taking 20 damage
            Current health: 70
            Healing by 50 hp
            Current health: 100
            */

        }
    }
}
