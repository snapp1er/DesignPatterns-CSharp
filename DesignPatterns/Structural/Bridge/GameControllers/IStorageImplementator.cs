using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural.Bridge.GameControllers
{
    interface IStorageImplementator
    {
        string ReadOperation();
    }

    class FileStorageImplementator : IStorageImplementator
    {
        public string ReadOperation()
        {
            return "Reading data from file...";
        }
    }

    class NetworkStorageImplementator : IStorageImplementator
    {
        public string ReadOperation()
        {
            return "Reading data from network...";
        }
    }
}
