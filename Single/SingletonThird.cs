using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Single
{
    //多线程单例模式 饿汉式2
    public class SingletonThird
    {
        //构造方法私有化 避免重复制造
        private SingletonThird()
        {
            Console.WriteLine("构造成功");
        }

        //静态字段 由CLR调用 在类型第一次被初始化调用 且只调用一次
        public static SingletonThird Instance = new SingletonThird();

        //静态方法提供实例 供外部引用
        public static SingletonThird CreateSingleton()
        {
            return Instance;
        }

        public void Show()
        {
            Console.WriteLine($"Hello *********************");
        }
    }
}