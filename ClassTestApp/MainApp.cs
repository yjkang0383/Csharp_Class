using System;
using System.Runtime.ExceptionServices;

namespace ClassTestApp
{
    class MainApp
    {
        static void Main(string[] args)
        {   
            //기본 생성자
            Console.WriteLine("야옹이 객체 생성 ");
            Cat kitty = new Cat();
            kitty.Name = "키티";
            kitty.Age = 3;
            kitty.Color = "하얀색";
            kitty.Meow();
            
             Cat nero = new Cat
            {
                Name = "네로",
                Age = 65,
                Color = "Black"
            }; 
            
            nero.Meow();

            //파라미터를 만들어 입력할 수 있게 만들어줌
            Cat mimi = new Cat("미미", "노랑", 3);
            mimi.Meow();

            Cat coco = new Cat("코코", "얼룩");
            coco.Age = 2;
            coco.Meow();

            Cat noname = new Cat("은색", 10);
            noname.Name = "야오옹이";
            noname.Meow();
            Console.WriteLine();


            //보통 var로 통일해서 사용함
            var list = (First : "Cat", Second : "Dog", Third : "Pig", 55);
            Console.WriteLine($"튜플 첫 번째 : {list.First}"); //First로 이름을 정하겠다
            Console.WriteLine($"튜플 두 번째 : {list.Item2}"); //item1,2,3는 이름을 지정하지 않았을 때 
            Console.WriteLine($"튜플 세 번째 : {list.Item3}"); //자동 생성 해줌
            Console.WriteLine($"튜플 네 번째 : {list.Item4}");
        }
    }
}
