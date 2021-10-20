using System;

namespace GenericTestApp
{
    class MainApp
    {
        static void Main(string[] args)                      //static ( 정적임 ) 은 메인에만 적용
        {   
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
            CopyArray(sourceInt, targetInt);                 // Art + 엔터 로 밑에 private static Copy 만들기
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
            CopyArray(sourceFloat, targetFloat);                 
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
            CopyArray(sourceString, targetString);
            Console.WriteLine("복사 후 targetString값===========");
            foreach (var item in targetString)
            {
                Console.Write($"{item}\t");
            } 
            Console.WriteLine();
        }

        private static void CopyArray(string[] source, string[] target) // String도 똑같다
        {
            for (int i = 0; i < source.Length; i++)
                target[i] = source[i];
        }
        private static void CopyArray(float[] source, float[] target) // Main이 static이므로 static이 되어야한다
        {
            for (int i = 0; i < source.Length; i++)
                 target[i] = source[i];
        }
        private static void CopyArray(int[] source, int[] target)    // 연산자 오버로딩이되므로 위의 float과 
        {                                                            // 이름이 같아도 가능하다
            for (int i = 0; i < source.Length; i++)
                target[i] = source[i];
        }
    }
}
