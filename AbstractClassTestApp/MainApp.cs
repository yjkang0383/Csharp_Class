using System;

namespace AbstractClassTestApp
{
    class MainApp
    {
        static void Main(string[] args)
        {   // 추상화로 자식클래스에 상속된 부모클래스를 사용하기 용이하게 한다 개념이해하기
            // AbstractBase obj = new AbstractBase();  <-- 추상클래스는 new를 못씀
            AbstractBase obj = new Derived();
            obj.PublicMethod();
            obj.AbstractMethod();
        }
    }
}
