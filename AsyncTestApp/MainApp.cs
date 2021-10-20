using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace AsyncTestApp
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
            Caller();
            Console.ReadLine();   // 프로그램 종료 방지
        }

        private static void Caller()
        {
            Console.WriteLine("Caller A");
            Console.WriteLine("Caller B");

            MyMethodAsync(3);     //비동기처리

            Console.WriteLine("Caller E");
            Console.WriteLine("Caller F");
        }

        async private  static void MyMethodAsync(int count)
        {
            Console.WriteLine("My C");
            Console.WriteLine("My D");

            await Task.Run(async () =>
            {
                for (int i = 1; i < count; i++)
                {
                    Console.WriteLine($"{i}/{count} ...");
                    await Task.Delay(1000);
                }
            });
            for (int i = 1; i <= count; i++)
            {
                Console.WriteLine($"{i}/{count} ...");
            }

            Console.WriteLine("My G");
            Console.WriteLine("My H");
        }
    }
}
