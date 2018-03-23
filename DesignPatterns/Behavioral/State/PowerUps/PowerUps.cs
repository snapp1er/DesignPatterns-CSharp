using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.State.PowerUps
{
    class Hero
    {
        IState state;
        public Hero()
        {
            state = new State();
        }
        public void Punch()
        {
            state.Punch();
        }
        public void Jump()
        {
            state.Jump();
        }
        public void PickUpPowerUp()
        {
            state = new SuperPower();
            Console.WriteLine("Picked up PowerUp");
        }
        public void PowerUpEnded()
        {
            state = new State();
            Console.WriteLine("PowerUp ended");
        }
    }
    interface IState
    {
        void Punch();
        void Jump();
    }
    class State : IState
    {
        public void Jump()
        {
            Console.WriteLine("jump");
        }
        public void Punch()
        {
            Console.WriteLine("punch");
        }
    }
    class SuperPower : IState
    {
        public void Jump()
        {
            Console.WriteLine("super jump");
        }
        public void Punch()
        {
            Console.WriteLine("super punch");
        }
    }
    class PowerUps
    {
        public static void Main(string[] args)
        {
            var hero = new Hero();
            for(int i=0; i<10; i++)
            {
                if (i == 3)
                    hero.PickUpPowerUp();
                if (i == 7)
                    hero.PowerUpEnded();
                if(i%2 ==0)
                {
                    hero.Punch();
                }
                else
                {
                    hero.Jump();
                }
            }
            /*
            punch
            jump
            punch
            Picked up PowerUp
            super jump
            super punch
            super jump
            super punch
            PowerUp ended
            jump
            punch
            jump
            */
        }
    }
}
