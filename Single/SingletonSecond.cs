using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Single
{
    //多线程单例模式 饿汉式
    public class SingletonSecond
    {
        //构造方法私有化 避免重复制造
        private SingletonSecond()
        {
            Console.WriteLine("构造成功");
        }

        //静态变量共享 保证唯一
        public static SingletonSecond Instance = null;

        //静态构造函数 由CLR调用 在类型第一次被使用前调用 且只调用一次
        static SingletonSecond()
        {
            Instance = new SingletonSecond();
        }

        //静态方法提供实例 供外部引用
        public static SingletonSecond CreateSingleton()
        {
            return Instance;
        }

        public void Show()
        {
            Console.WriteLine($"Hello *********************");
        }
    }
}