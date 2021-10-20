using System;

namespace PropertyTestApp
{
    class MainApp
    {
        // 클래스는 프로퍼티와 메서드로 구분된다 !!
        static void Main(string[] args)
        {
            Console.WriteLine("강아지객체 생성!");
            Dog baekgoo = new Dog();

            //baekgoo.SetAge(5);
            baekgoo.Name = "백구";

            //Console.WriteLine($"백구의 나이는 {baekgoo.GetAge()} 살 입니다.");
            baekgoo.Age = 25000;
            Console.WriteLine($"백구의 나이는 {baekgoo.Age} 세");

            Dog streetDog = new Dog();
            Console.WriteLine($"{streetDog.Name}는 {streetDog.Color} 색입니다.");

            Dog dog1 = new Dog();
            dog1.Name = "황구";
            dog1.Color = "노랑색";
            dog1.Age = 10;

            Dog dog2 = new Dog();
            {
                dog2.Name = "깜장이"; 
                dog2.Age = 5;
                dog2.Color = "검정색";
            };

            // 무명 형식
            var myInstance = new { Name = "김종우", Age = 27 };
            Console.WriteLine(myInstance.Name);
            Console.WriteLine(myInstance.Age);

        }
    }
}
