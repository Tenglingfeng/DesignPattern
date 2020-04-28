using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Single
{
    //多线程单例模式 懒汉式
    public class Singleton
    {
        //构造方法私有化 避免重复制造
        private Singleton()
        {
            Console.WriteLine("构造成功");
        }

        //静态变量共享 保证唯一
        public static Singleton Instance = null;

        public static readonly Object LockSingleton = new object();

        //静态方法提供实例 供外部引用
        public static Singleton CreateSingleton()
        {
            if (Instance == null)               //双判断锁   只有用到实例,才会被构造
            {
                lock (LockSingleton)
                {
                    Console.WriteLine($"进入lock,排队");
                    Thread.Sleep(1000);
                    if (Instance == null)
                    {
                        Instance = new Singleton();
                    }
                }
            }

            return Instance;
        }

        public void Show()
        {
            Console.WriteLine($"Hello *********************");
        }
    }
}