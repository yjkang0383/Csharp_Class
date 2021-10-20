using System;

namespace GenericMyListApp
{
    class MainApp
    {
        static void Main(string[] args)
        {
            MyList<int> list = new MyList<int>();
            for (int i = 0; i < list.Length; i++)
            {
                list[i] = i + 1;
            }
            for (int i = 0; i < list.Length; i++)
            {
                Console.Write($"{list[i]}\t");
            }

            MyList<string> strlist = new MyList<string>();
            for (int i = 0; i < strlist.Length; i++)
            {
                strlist[i] = "Hello" + (i + 1);
            }
            for (int i = 0; i < strlist.Length; i++)
            {
                Console.Write($"{strlist[i]}\t");
            }
        }
    }
}
