using System;

namespace Singleton
{
    //单线程单例模式
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
            lock (LockSingleton)
            {
                if (Instance == null)
                {
                    Instance = new Singleton();
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