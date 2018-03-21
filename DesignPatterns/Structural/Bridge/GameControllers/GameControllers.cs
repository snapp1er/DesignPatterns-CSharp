using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural.Bridge.GameControllers
{
    class GameControllers
    {
        public static void Main(string[] args)
        {
            IController controller;
            controller = new PlayerController(new FileStorageImplementator());
            Console.WriteLine("{0}", controller.Read());
            //Reading data from file...

            controller = new NPCController(new FileStorageImplementator());
            Console.WriteLine("{0}", controller.Read());
            //Reading data from file...

            controller = new NPCController(new NetworkStorageImplementator());
            Console.WriteLine("{0}", controller.Read());
            //Reading data from network...
        }
    }
}
