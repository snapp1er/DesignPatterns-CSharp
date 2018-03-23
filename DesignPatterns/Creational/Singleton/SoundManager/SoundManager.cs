using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.Singleton.SoundManager
{
    class SoundManager
    {
        private static SoundManager instance;
        public static SoundManager Instance
        {
            get { return instance; }
        }
        public static void Init()
        {
            if(instance == null)
            {
                instance = new SoundManager();
            }
        }
        private SoundManager()
        {
        }
        public void PlaySound(int n)
        {
            Console.WriteLine("Playing sound : {0}", n);
        }
        public static void Main(string[] args)
        {
            SoundManager.Init();
            SoundManager.Instance.PlaySound(3);
            SoundManager.Instance.PlaySound(15);
            /*
            Playing sound : 3
            Playing sound : 15
            */
        }
    }
}
