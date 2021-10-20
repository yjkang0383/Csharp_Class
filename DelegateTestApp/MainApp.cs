using System;

namespace DelegateTestApp
{
    class MainApp
    {
        static void Main(string[] args)
        {   
            // 일반적인 호출
            Calculator calc = new Calculator();
            Console.WriteLine($"3 + 5 = {calc.Plus(3, 5)}");
            Console.WriteLine($"3 / 5 = {calc.Divide(3, 5)}");

            // 대리자 호출
            //대리자한테 어떤 일을 떠넘겨서 하라고함
            CalcDelegate callBack;
            callBack = new CalcDelegate(calc.Plus);
            Console.WriteLine($"4 + 6 = {callBack(4, 6)}");
            callBack = new CalcDelegate(calc.Multiple);
            Console.WriteLine($"4 * 6 = {callBack(4, 6)}");
        }
    }
}
