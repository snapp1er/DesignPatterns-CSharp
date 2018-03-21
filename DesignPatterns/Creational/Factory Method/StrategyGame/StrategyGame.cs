using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.Factory_Method.StrategyGame
{
    class StrategyGame
    {
        public static void Main(string[] args)
        {
            var barracks = new Barracks();
            Archer archer;
            archer = barracks.ProduceArcher();
            Console.WriteLine("new archer : {0}", archer.Characteristics());
            barracks.Upgrade();
            Console.WriteLine("Barracks upgraded to 17 century");
            archer = barracks.ProduceArcher();
            Console.WriteLine("new archer : {0}", archer.Characteristics());

            /*
            new archer : I am a 16th century archer
            Barracks upgraded to 17 century
            new archer : I am a 17th century archer
            */
        }
    }
}
