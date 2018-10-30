using System;

namespace sortTest
{
    public class selection
    {
        public static void selectionSort()
        {
            int[] array = new int[5000];
            Random Rnd = new Random();
            for (int i = 0; i < array.Length; i++)
                array[i] = Rnd.Next(0, 100000);
            sort(array);
        }

        private static void sort(int[] array)
        {
            for (int i = 0; i <= array.Length; i++)
            {
                int min = 0;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] <= min)
                    {
                        int tmp = array[j];
                        array[j] = min;
                        min = tmp;
                    }
                }
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}