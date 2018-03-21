using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural.Bridge.GameControllers
{
    interface IController
    {
        string Read();
    }

    abstract class Controller : IController
    {
        protected IStorageImplementator implementator;

        public Controller(IStorageImplementator implementator)
        {
            this.implementator = implementator;
        }

        public string Read()
        {
            return implementator.ReadOperation();
        }
    }

    class PlayerController : Controller
    {
        public PlayerController(IStorageImplementator s) : base(s) {}
    }

    class NPCController : Controller
    {
        public NPCController(IStorageImplementator s) : base(s) {}
    }

}
