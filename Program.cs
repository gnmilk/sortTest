using System;

namespace sortTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("輸入使用的搜尋演算法(1.bubble sort)");
            char i = Convert.ToChar(Console.ReadLine());
            choice(i);
        }

        static void choice(char i)
        {
            switch (i)
            {
                case '1':
                    bubble.bubbleSort();
                    break;
                default:
                    choice(i);
                    break;
            }
        }
    }
}
