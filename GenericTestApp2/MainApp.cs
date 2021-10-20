using System;

namespace GenericTestApp2
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Generic 사용 배열 카피 !");
            // int형식
            // int배열을 int배열로 복사
            int[] sourceInt = { 1, 2, 3, 4, 5 };
            int[] targetInt = new int[sourceInt.Length];     // 5개짜리 int 배열
            // {0, 0, 0, 0, 0}
            // 복사 전
            Console.WriteLine("복사 전 targetInt값===========");
            foreach (var item in targetInt)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();
            //복사 후
            CopyArray<int>(sourceInt, targetInt);                 // Art + 엔터 로 밑에 private static Copy 만들기
            Console.WriteLine("복사 후 targetInt값===========");
            foreach (var item in targetInt)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();
            Console.WriteLine();

            //Float 형식
            float[] sourceFloat = { 1.2f, 2.3f, 3.4f, 4.5f, 5.6f };
            float[] targetFloat = new float[sourceFloat.Length];      // 5개짜리 배열
            // 복사 전
            Console.WriteLine("복사 전 targetFloat값===========");
            foreach (var item in targetFloat)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();
            //복사 후
            CopyArray<float>(sourceFloat, targetFloat);
            Console.WriteLine("복사 후 targetFloat값===========");
            foreach (var item in targetFloat)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();
            Console.WriteLine();

            // String 형식
            string[] sourceString = { "하나", "둘", "셋", "넷", "다섯", "여섯" };
            string[] targetString = new string[sourceString.Length];
            // 복사 전
            Console.WriteLine("복사 전 targetString값===========");
            foreach (var item in targetString)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();
            //복사 후
            CopyArray<string>(sourceString, targetString);
            Console.WriteLine("복사 후 targetString값===========");
            foreach (var item in targetString)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();
        }
        
        // 일반화 메서드 통일
        private static void CopyArray<T>( T[] source, T[] target) 
        {
            for (int i = 0; i < source.Length; i++)
                target[i] = source[i];
        }
    }
}
