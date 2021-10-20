using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTestApp
{
    class Cat : Animal //상속받았으니까 Cat에서 Animal에 있는 protected 쓸 수 있음 , 메인에선 못씀
    {
        //기본 생성자
        public string Name { get; set; }
        public string Color { get; set; }
        public int Age { get; set; }
        public Cat() { /* Nothing */}

        //입력할 수 있게 만듬 (얘를 더 많이 씀)
        public Cat(string name, string color, int age)
        {
            //초기화
            this.Name = name;
            this.Color = color;
            this.Age = age;
        }

        public Cat(String name, string color)
        {
            //초기화
            this.Name = name;
            this.Color = color;
        }

        /*        컴퓨터는 타입으로 구분하기 때문에 에러가 난다
       public Cat(String color, string name)
       {
           //생성자 오버로딩
           this.Color = color;
           this.Name = name;
       } */
        public Cat(String name, int age)
        {
            //생성자 오버로딩 ( 타입이 다르기 때문에 에러가안뜸)
            this.Name = name;
            this.Age = age;
        }

        public void Meow() { Console.WriteLine($"{this.Color} {this.Name}, 냐옹~! "); }

        public override void sleep()
        {   
            base.sleep(); //부모의 sleep() 실행
                          // 이후 자식 클래스의 sleep 내용 실행
            Console.WriteLine($"{this.Color} 고양이 {this.name} 이가 ZZ잡니다~!");
        }
    }
}
