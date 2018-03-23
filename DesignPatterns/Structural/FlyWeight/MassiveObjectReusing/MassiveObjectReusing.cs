using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural.FlyWeight.MassiveObjectReusing
{
    class MassiveObject
    {
        int[,] indexes;
        public MassiveObject()
        {
            Random rand = new Random();
            indexes = new int[100,100];
            for(int i=0; i<100; i++)
            {
                for(int j=0; j<100; j++)
                {
                    indexes[i, j] = rand.Next(0, 100);
                }
            }
        }

        public int this[int i, int j]
        {
            get { return indexes[i, j]; }
        }
    }

    class Item
    {
        static MassiveObject mo = new MassiveObject();

        public int GetIndex(int i, int j)
        {
            return mo[i, j];
        }
    }

    
    class MassiveObjectReusing
    {
        public static void Main(string[] args)
        {
            var item1 = new Item();
            Console.WriteLine("item1[0,0] : {0}", item1.GetIndex(0, 0));
            var item2 = new Item();
            Console.WriteLine("item2[0,0] : {0}", item2.GetIndex(0, 0));
            Console.WriteLine("item2[22,33] : {0}", item2.GetIndex(22, 33));
            /*
            item1[0,0] : 51
            item2[0,0] : 51
            item2[22,33] : 42
            */
        }
    }
}
