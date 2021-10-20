using System;

namespace ExceptionTestApp
{
    class MainApp
    {
        static void Main(string[] args)
        {   
            // 예외 처리
            Console.WriteLine("프로그램 시작 - !");

            int[] list = { 107, 108, 109 };

            try
            {
                string message = null;
                Console.WriteLine(message.Length);

                var result = list[1] / 0;
                for (int i = 0; i <= 5; i++)
                {
                    Console.WriteLine(list[i]);
                }
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine($" 예외발생 : {ex.Message} ");
                // IndexOutOfRange예외시 다른일 처리
                Console.WriteLine("IndexOutOfRangeException 이후 처리!");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($" 예외발생 : {ex.Message} ");
                Console.WriteLine("DivideByZeroException 이후 처리 !!!");
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine($" 예외발생 : {ex.Message} ");
                Console.WriteLine(" 입력 쫌 제발 제대로 해라 XXX !!!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($" 예외발생 : {ex.Message} ");   // 위와 같이 예외발생 경우가 많으니까 이거 하나로 퉁치기
            }

            // finally 예외가 발생하든 안하든 실행됨
            finally
            {
                Console.WriteLine("Finally, 언제든지 실행됨. ");
            }

            Console.WriteLine("프로그램 종료!"); 
        }
    }
}
