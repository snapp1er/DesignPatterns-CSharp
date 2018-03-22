using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Linq;
using System.Diagnostics;

namespace DesignPatterns.Creational.Object_Pool.EnemyPool
{
    class Enemy
    {
        int health;

        public Enemy()
        {
            //Very Long creation
            Thread.Sleep(100);
            Init();
        }

        public void Init()
        {
            health = 100;
        }
    }

    interface IObjectPool<T> where T : new()
    {
        void Init();
        T Get();
        void Free(T o);
    }

    class EnemyPool : IObjectPool<Enemy>
    {
        private static int Size = 25;        
        Dictionary<Enemy, bool> allocated;
        
        public static void Main(string[] args)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            var pool = new EnemyPool();
            pool.Init();
            stopwatch.Stop();
            Console.WriteLine("Pool initialized in {0}ms", stopwatch.ElapsedMilliseconds);
            stopwatch.Reset();


            stopwatch.Start();
            var enemies = Enumerable.Range(1, 20).Select(i => pool.Get()).ToList();
            enemies.ForEach(t => t.Init());
            enemies.ForEach(t => pool.Free(t));

            enemies = Enumerable.Range(1, 20).Select(i => pool.Get()).ToList();
            enemies.ForEach(t => t.Init());
            enemies.ForEach(t => pool.Free(t));
            stopwatch.Stop();
            Console.WriteLine("Operations made in {0}ms", stopwatch.ElapsedMilliseconds);
            stopwatch.Reset();



            //Same Without pool
            stopwatch.Start();
            enemies = Enumerable.Range(1, 20).Select(i => new Enemy()).ToList();
            enemies.ForEach(t => t.Init());

            enemies = Enumerable.Range(1, 20).Select(i => new Enemy()).ToList();
            enemies.ForEach(t => t.Init());
            stopwatch.Stop();

            Console.WriteLine("Same Operations without pool : {0}ms", stopwatch.ElapsedMilliseconds);
            /* OUTPUT:
            Pool initialized in 2507ms
            Operations made in 14ms
            Same Operations without pool : 4010ms
            */
        }

        public void Init()
        {
            allocated = new Dictionary<Enemy, bool>();
            for(int i=0; i<Size; i++)
            {
                allocated.Add(new Enemy(), false);
            }
        }

        public void Free(Enemy o)
        {
            allocated[o] = false;
        }

        public Enemy Get()
        {
            foreach(var e in allocated)
            {
                
                if(e.Value == false)
                {
                    allocated[e.Key] = true;
                    return e.Key;
                }
            }
            throw new Exception("Limit exceeded");
        }

        
    }
}
