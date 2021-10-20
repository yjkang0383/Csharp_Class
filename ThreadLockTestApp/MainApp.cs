using System;
using System.Threading;

namespace ThreadLockTestApp
{
    class MainApp
    {
        class Counter
        {
            private int counter = 1000;

            private object thislock = new object();   // 오브젝트 형식의 개체를 만들어서

            public void Run()
            {
                for (int i = 0; i < 10; i++)
                {
                    Thread th = new Thread(UnsafeCalc);   // 10개의 스레드 생성
                    th.Start();
                }
            }
            public void UnsafeCalc()
            {   
                lock (thislock)  // lock을 통해서 동기화(다른스레드가 접근못하도록)
                {
                    counter++;
                    Thread.Sleep(100);
                    Console.WriteLine(counter);
                }
            }
        }

        static void Main(string[] args)
        {
            Counter counter = new Counter();

            counter.Run();
        }
    }
}
