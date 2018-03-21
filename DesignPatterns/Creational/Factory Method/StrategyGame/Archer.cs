using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.Factory_Method
{
    abstract class Archer
    {
        public abstract string Characteristics();
    }

    class ArcherOf16Century : Archer
    {
        private string whoami = "I am a 16th century archer";
        public override string Characteristics()
        {
            return whoami;
        }
    }
    class ArcherOf17Century : Archer
    {
        private string whoami = "I am a 17th century archer";
        public override string Characteristics()
        {
            return whoami;
        }
    }
}
