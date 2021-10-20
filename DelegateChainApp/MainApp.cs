﻿using System;

namespace DelegateChainApp
{
    delegate int Calculate(int a, int b);  // 계산 대리자를 선언

    class MainApp
    {
        static void Main(string[] args)
        {
            #region
            FireStation station = new FireStation();
            
            ThereIsAFire fireHouse = new ThereIsAFire(station.Call119);
            fireHouse += new ThereIsAFire(station.ShoutOut);
            fireHouse += new ThereIsAFire(station.Escape);

            // 대리자 실행 ---- 대리자 하나 실행했는데 메서드3개가 출력됨
            fireHouse("우리집");
            Console.WriteLine();

            ThereIsAFire fireWoorim = new ThereIsAFire(station.Call119);
            fireWoorim += new ThereIsAFire(station.Escape);

            // 대리자 실행  ---- 원하는만큼 메서드를 출력할 수 있음
            fireWoorim("우림라이온밸리A");

            #endregion

            Calculate calc;
            //무명함수 표현1
            /* 
            calc = delegate (int a, int b)
            {
                return a + b;
            };
            */
            //무명함수 표현 2 = 람다식
            calc = (a, b) => a + b;
            Console.WriteLine($"a + b = {calc(3,5)}");
        }
    }
}
