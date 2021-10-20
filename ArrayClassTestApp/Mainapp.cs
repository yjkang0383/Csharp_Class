using System;
using System.Collections.Immutable;

namespace ArrayClassTestApp
{
    class Mainapp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Array 클래스 사용");

            int[] array = new int[] { 5, 7, 3, 1, 9, 10, 4, 8, 2, 6};

            foreach (var item in array)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();

            System.Array.Sort(array);    // 오름차순 정렬
            foreach (var item in array)
            {
                Console.Write($"{item}\t");
            }

            Console.WriteLine();
            Array.Reverse(array);         //내림차순 정렬
            foreach (var item in array)
            {
                Console.Write($"{item}\t");
            }

            //특정 숫자 찾기
            Console.WriteLine();
            int index7 = Array.IndexOf(array, 7);
            Console.WriteLine($"7의 위치는 {index7}");

            // Resize 메소드를 써서 array의 사이즈를 늘려준다
            // 11로 array크기를 늘린 후 100을 넣었다
            Array.Resize<int>(ref array, 11);
            array[10] = 100;
            foreach (var item in array)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();
        }
    }
}
