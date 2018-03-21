using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.Abstract_Factory
{
    interface IFactory
    {
        IWidget CreateButton();
        IWidget CreateText();
    }
}
