using System;
using System.Collections;

namespace CollectionTestApp
{
    class MainApp
    {
        static void Main(string[] args)
        {
           /* 
             
            int a = 123;       // 박싱
            object obj =  a;   // 언박싱
            int b = (int)obj;

            Console.WriteLine("a의 타입 : " + a.GetType());
            Console.WriteLine("obj의 타입 : " + obj.GetType());
            Console.WriteLine("b의 값 : " + b);

            string str = "문자열임";
            obj = str;
            Console.WriteLine("str의 값 : " + str);
            Console.WriteLine("obj의 값 : " + obj );
          
            */

            Console.WriteLine("ArrayList 예제");

            ArrayList list = new ArrayList();  // 사이즈 지정x
            list.Add(3);
            list.Add(67);
            list.Add(14);
            list.Add(30);
            list.Add(14);

            // object는 모든 클래스들의 조상
            // 들어가는 모든 값들이 object로 바뀐다 383pg
            // 박싱된다 68pg
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }


            // 형식이 달라서 소팅이 안됨
            // 같은 형식을 넣어주면 된다
            list.Sort();

            foreach (var item in list)
            {
                Console.WriteLine($"{item}\t");
            }
            Console.WriteLine();


            list.Add(100);
            foreach (var item in list)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();
            Console.WriteLine();

            // 2번째 인덱스에 88을 넣는다
            list.Insert(2, 88);
            foreach (var item in list)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();

            //5번 인덱스를 지운다
            list.RemoveAt(5);
            foreach (var item in list)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();

            int index100 = list.IndexOf(100);
            Console.WriteLine($"100의 위치 : {index100}");

            // 5라는 값을 지워라
            list.Remove(5);
            foreach (var item in list)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();

            list.Add(133);
            list.Add(14);
            
            foreach (var item in list)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();

            // 찾는 값이 2개 일 대 앞에거가 나옴
            int index14 = list.IndexOf(14);
            Console.WriteLine($"14의 위치 값 : {index14}");

            int lstindex14 = list.LastIndexOf(14);
            Console.WriteLine($"14의 마지막 위치 값 : {lstindex14}");

            // 총 갯수, 마지막 값
            Console.WriteLine($"총 갯수 {list.Count}");
            Console.WriteLine($"리스트 마지막 값은 {list[list.Count-1]}");
        }
    }
}
