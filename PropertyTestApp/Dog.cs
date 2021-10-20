using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PropertyTestApp
{
    class Dog
    {
       /* public string GetName() { return this.name;}
        public void SetName(string name) { this.name = name; }
       */

        private int age;
        //private string name;

        //자동부여 property
        public string Name { get; set; } = "멍뭉이"; //초기값 멍뭉이
        public string Color { get; set; } = "하얀"; // 초기값 하얀
       

        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value <0)
                {
                    this.age = 1;
                }
                else if ( value > 15)
                {
                    this.age = 15;
                }
                else
                {
                    this.age = value;
                }
                this.age = value;
            }
        }
        /*
         
        // 값을 사용
        public int GetAge() { return this.age; }

        // 값을 설정
        public void SetAge(int age)
        {
            if (age < 0)
            {
                this.age = 1;
            }
            else if (age > 15)
            {
                this.age = 15;
            }
            else
            {
                this.age = age;
            }
        }
        */
    }
}
