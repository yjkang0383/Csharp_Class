using System;
using System.Collections.Generic;


namespace IndexerTestApp
{
    class Mylist // : IEnumerable, IEnumerator
    {
        private int[] array;

        // 배열화 (배열이 아닌 MyList를 배열처럼 만들어주는 프로퍼티)
        public int this[int index]    // == MyList[i] ==array[i]
        {
            get
            {
                return array[index];
            }
            set
            {
                if (index >= array.Length) // 하나씩 증가
                {
                    System.Array.Resize(ref array, index + 1);
                    Console.WriteLine($"Array resized : {array.Length}");
                }
                array[index] = value;
            }
        }

        public int Length
        {
            get { return array.Length; } // 3
        }

        /* 
         // IEnumarator
        public object Current
        {
            get { return array[position];  } // 현재 값 foreach 할때만 필요
        }

        public bool MoveNext()
        {
            position++;
            return (position < array.length);
        }

        */

        public Mylist()
        {
            array = new int[3];   // 0, 1, 2
        }
        // public 
    }
}
