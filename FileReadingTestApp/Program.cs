using System;
using System.IO;

namespace FileReadingTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string fullPath = @"C:\Test\Help\PFRO.log";
            StreamReader sr = new StreamReader(new FileStream(fullPath, FileMode.Open));

            while (sr.EndOfStream == false)
            {
                Console.WriteLine(sr.ReadLine());
            }
            sr.Close();     //필수
            // 텍스트파일 읽어오는 부분
            Console.WriteLine("텍스트파일 읽기완료!!");

            string writePath = @"C:\Test\Help\KJW.txt";
            StreamWriter sw = new StreamWriter(new FileStream(writePath, FileMode.Create));

            sw.Write("hello world!\n");
            sw.Write("안녕하세요감사해요잘있어요다시만나요\n");
            sw.Write(3.141592f);
            sw.Close();     // 필수

            Console.WriteLine("텍스트파일 작성완료!!");

        }
    }
}
