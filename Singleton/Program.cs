using System;
using System.Threading.Tasks;

namespace Singleton
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            try
            {
                for (int i = 0; i < 5; i++)
                {
                    Task.Run(() =>
                    {
                        Singleton singleton = Singleton.CreateSingleton();
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