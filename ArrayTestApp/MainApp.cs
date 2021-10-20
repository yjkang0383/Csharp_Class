using System;

namespace ArrayTestApp
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("대성 마이맥 수학점수!");
            //초기화
            //int[] scores = new int[] { 80, 75, 33, 100, 68 };
            int[] scores = { 80, 75, 33, 100, 68 }; //최종적으로 제일 짧게만든 것
         
            /* scores[0] = 80;
            scores[1] = 75;
            scores[2] = 33;
            scores[3] = 100;
            scores[4] = 68;
         */
            //학생 수학점수 총합
            int sum = 0;
            /*  for (int i = 0; i < scores.Length; i++)
             {
                 sum += scores[i];
             } */

            foreach (var item in scores)
            {
                sum += item;
            }
            //학생 수학점수 평균
            float average = (float)sum / scores.Length;

            Console.WriteLine($"수학점수 총합 : {sum}, 평균 : {average} ");
        }
    }
}
