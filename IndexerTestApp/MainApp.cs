using System;
using System.Collections.Generic;

namespace IndexerTestApp
{
    class MainApp
    {
        static void Main(string[] args)
        {   
            Console.WriteLine(" MyList 예제! ");

            Mylist list = new Mylist();
            for (int i = 0; i < 5; i++)
            {
                list[i] = (i + 1);   // 1~5
            }

            for (int i = 0; i < list.Length; i++)
            {
                Console.WriteLine(list[i]);
            }

        }
    }
}
