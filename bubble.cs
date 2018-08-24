using System;

namespace sortTest
{
    public class bubble
    {
        public static void bubbleSort()
        {
            int[] array = new int[5000];

            Random Rnd = new Random();

            for (int i = 0; i < array.Length; i++)
                array[i] = Rnd.Next(0, 100000);

            sort(array);

        }

        private static void sort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
                for (int j = 0; j < array.Length - 1 - i; j++)
                {
                    if (array[j] > array[j + 1])
                        swap(array, j);
                }

            for (int i = 0; i < array.Length; i++)
                Console.WriteLine(array[i]);
        }

        private static int[] swap(int[] array, int j)
        {
            int tmp = array[j + 1];
            array[j + 1] = array[j];
            array[j] = tmp;

            return array;
        }
    }
}