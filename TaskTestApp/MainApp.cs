﻿using System;
using System.Threading;
using System.Threading.Tasks;

namespace TaskTestApp
{
    class MainApp
    {
        static void Main(string[] args)
        {
            var myTask = Task.Run(() => {
                    // Task로 비동기 처리할 내용
                    Thread.Sleep(1000);    // 1초동안 작업이 처리됨(대규모일) 8500만개 연산수행
                Console.WriteLine("비동기 처리 완료!");
                });

            var sum = 0;
            for (int i = 0; i < 1000; i++)
            {
                sum += i;
            }
            Console.WriteLine($"메인스레드 동기처리 : {sum} ");
            myTask.Wait();   // 비동기 호출이 완료될때까지 대기.....
        }
    }
}
