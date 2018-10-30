using System;

namespace sortTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("輸入使用的搜尋演算法(1.bubble sort 2.selection sort)");
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
                case '2':
                    selection.selectionSort();
                    break;
                default:
                    choice(i);
                    break;
            }
        }
    }
}
