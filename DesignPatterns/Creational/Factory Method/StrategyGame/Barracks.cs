using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.Factory_Method
{
    class Barracks : IArcherProducer
    {
        int century = 16;

        public Archer ProduceArcher()
        {
            if (century == 16)
                return new ArcherOf16Century();
            else
                return new ArcherOf17Century();
        }

        public void Upgrade()
        {
            century = 17;
        }


    }
}
