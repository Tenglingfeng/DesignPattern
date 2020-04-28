using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Single
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //try
            //{
            //    List<Task> tasks = new List<Task>();
            //    for (int i = 0; i < 5; i++)
            //    {
            //        tasks.Add(
            //                Task.Run(() =>
            //                {
            //                    Singleton singleton = Singleton.CreateSingleton();
            //                    singleton.Show();
            //                })
            //        );
            //    }
            //    for (int i = 0; i < 5; i++)
            //    {
            //        Task.Run(() =>
            //        {
            //            Singleton singleton = Singleton.CreateSingleton();
            //            singleton.Show();
            //        });
            //    }
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e);
            //    throw;
            //}

            try
            {
                List<Task> tasks = new List<Task>();
                for (int i = 0; i < 5; i++)
                {
                    tasks.Add(
                        Task.Run(() =>
                        {
                            SingletonThird singleton = SingletonThird.CreateSingleton();
                            singleton.Show();
                        })
                    );
                }
                for (int i = 0; i < 5; i++)
                {
                    Task.Run(() =>
                    {
                        SingletonThird singleton = SingletonThird.CreateSingleton();
                        singleton.Show();
                    });
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            Console.ReadKey();
        }
    }
}