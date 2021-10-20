using System;
using System.Threading;

namespace BasicThreadTestApp
{
    class Program
    {   // 19.1.1 스레드 시작하기
        static void Main(string[] args)
        {
            //DoSomething();
            Thread th1 = new Thread(DoSomething);
            th1.Start();
            //th1.Join();은 안 넣어도 된다  // 스레드 종료 대기
            DoOtherthing();

            //th1.Abort();    // 더이상 사용안함 
        }
        
        private static void DoOtherthing()
        {
            for (int i = 0; i < 30; i++)
            {
                Console.WriteLine($"DoOtherthing : {i} ");
                Thread.Sleep(10);  // 10ms 대기
            }
        }
        private static void DoSomething()
        {
            for (int i = 0; i < 30; i++)
            {
                Console.WriteLine($"DoSomething : {i} ");
                Thread.Sleep(10);   // 10ms 대기
            }
        }
    }
}
