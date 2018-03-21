using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.Abstract_Factory
{
    class WindowsFactory : IFactory
    {
        public IWidget CreateButton()
        {
            return new WindowsButton();
        }

        public IWidget CreateText()
        {
            return new WindowsText();
        }
    }

    class LinuxFactory : IFactory
    {
        public IWidget CreateButton()
        {
            return new LinuxButton();
        }

        public IWidget CreateText()
        {
            return new LinuxText();
        }
    }
}
