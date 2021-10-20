using System;

namespace ClassTestApp
{
    class Animal
    {
        private int UniqueID { get; set; }
        protected string name { get; set; }
        public void Eat(string meal)
        {
            Console.WriteLine($"{this.name} 이 {meal} 을 먹습니다");         
        }
        public virtual void sleep() { Console.WriteLine($"{this.name} 이가 잠을 잡니다./ "); }
    }
}
