using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHandlerApp
{
    //이벤트 핸들러
    delegate void EventHandler(string message); // 대리자 선언
    class MyNotifier
    {
        public event EventHandler SomethingHappened;

        public void DoSomething(int number)
        {
            //삼육구
            int temp = number % 10;
            if (temp != 0 && temp % 3 ==0)  // 3, 6, 9
            {
                SomethingHappened($"짝! \t");
            }
            else
            {
                SomethingHappened($"{number}\t");
            }
        }
    }
}
