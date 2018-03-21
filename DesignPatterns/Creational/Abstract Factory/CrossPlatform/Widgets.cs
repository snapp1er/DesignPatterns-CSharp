using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.Abstract_Factory
{
    class LinuxButton : IWidget
    {
        public void Render()
        {
            Console.WriteLine("rendering LinuxButton");
        }
    }

    class LinuxText : IWidget
    {
        public void Render()
        {
            Console.WriteLine("rendering LinuxText");
        }
    }

    class WindowsButton : IWidget
    {
        public void Render()
        {
            Console.WriteLine("rendering WindowsButton");
        }
    }

    class WindowsText : IWidget
    {
        public void Render()
        {
            Console.WriteLine("rendering WindowsText");
        }
    }
}
