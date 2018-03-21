#define Linux

using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.Abstract_Factory
{
    class CrossPlatform
    {
        public static void Main(string[] args)
        {
#if Linux
            IFactory factory = new LinuxFactory();
#else
            IFactory factory = new WindowsFactory();
#endif
            //Creating window
            IWidget[] widgets = new IWidget[3];
            widgets[0] = factory.CreateText();
            widgets[1] = factory.CreateText();
            widgets[2] = factory.CreateButton();

            //Rendering
            foreach(var w in widgets)
            {
                w.Render();
            }
            /*
             rendering LinuxText
             rendering LinuxText
             rendering LinuxButton
            */
        }
    }
}
