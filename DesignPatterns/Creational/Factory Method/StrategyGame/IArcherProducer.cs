using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.Factory_Method
{
    interface IArcherProducer
    {
        Archer ProduceArcher();
    }
}
