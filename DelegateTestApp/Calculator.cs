using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateTestApp
{   // Delegate 위치는 보통 class 밖
    // (int a, int b) <------- 모양이 틀리면 안 된다
    delegate int CalcDelegate(int a, int b);     // 대리자 선언
    
    class Calculator
    {
        public int Plus(int a, int b)  { return a + b; }
        public int Minus(int a, int b)  { return a - b; }
        public int Multiple(int a, int b)  { return a * b; }
        public int Divide(int a, int b)  { return a / b; }
    }
}
