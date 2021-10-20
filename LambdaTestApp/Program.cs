using System;

namespace LambdaTestApp
{
    class Program
    {
        // 익명함수를 활용한 람다
        delegate void DoSomething(string name);        // void 는 return이 없는게 아니라 return한 값이 없는것
        delegate string Concatenate(string[] arr);     

        static void Main(string[] args)
        {
            DoSomething doIt = (name) =>
            {
                Console.WriteLine($"Hi, ");
                Console.WriteLine($"{name} ~! ");
                //return;  // void이기 때문에 생략가능
            };
            string name = "Hugo";
            doIt(name);

            Concatenate concat = (arr) =>
            {
                string result = "";
                foreach (var item in arr)
                {
                    result += item;
                }
                return result;
            };

            string[] strarr = { "아버지가 ", "방에", "들어가신다" };
            Console.WriteLine(concat(strarr));

            // Func 대리자
            Func<int> func1 = () => 3;

            var val = func1();
            Console.WriteLine($"val의 값은 {val} .");

            Func<int, int, int> plus = (x, y) => x + y;
            Console.WriteLine($"3 + 5 = {plus(3, 5)}");

            // Action 대리자
            Action<int> area = (r) => {
                Console.WriteLine($"원의 넓이는 {(double) r * r * Math.PI}");
            };
            area(10);


        }
    }
}
