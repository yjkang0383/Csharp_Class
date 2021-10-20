using System;
using System.Collections.Generic;

namespace GenericCollectionApp
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("일반화 컬렉션 테스트=========!");

            List<int> list = new List<int>();
            for (int i = 0; i <= 1000; i++)
            {
                list.Add(i);
            }
            var sum = 0;
            foreach (var item in list)
            {
                sum += item;
            }
            Console.WriteLine($"1~1000의 합 = {sum} ");

            foreach (var item in list)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();

            Queue<string> lines = new Queue<string>();
            lines.Enqueue("첫 번쨰 손님");
            lines.Enqueue("두 번쨰 손님");
            lines.Enqueue("세 번쨰 손님");
            lines.Enqueue("네 번쨰 손님");

            while (lines.Count>0)
            {
                Console.WriteLine(lines.Dequeue());
            }

            // 제일 중요 @@!!!!!!
            Dictionary<string, int> dics = new Dictionary<string, int>();
            dics["하나"] = 1;
            dics["둘"] = 2;
            dics["셋"] = 3;
            dics["넷"] = 4;
            dics["다섯"] = 5;

            Console.WriteLine(dics["하나"]);
            Console.WriteLine(dics["셋"]);
            Console.WriteLine(dics["다섯"]);
            
            foreach (var item in dics)
            {
                Console.WriteLine($" {item.Key} : {item.Value} ");
            }
        }
    }
}
