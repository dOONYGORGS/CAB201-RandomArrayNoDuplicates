using System;

namespace RandomArray
{
    public class RandomArrayNoDuplicates
    {
        static Random rng = new Random();
        /// <summary>
        /// Creates an array with each element a unique integer
        /// between 1 and 45 inclusively.
        /// </summary>
        /// <param name="size"> length of the returned array < 45
        /// </param>
        /// <returns>an array of length "size" and each element is
        /// a unique integer between 1 and 45 inclusive </returns>
        public static int[] InitializeArrayWithNoDuplicates(int size)
        {
            int min = 1;
            int max = 45;
            int position = 0;
            int found = 0;

            int[] array = new int[size];
            for(int i = 0; i < size; i++)
            {
                int rand = rng.Next(min, max);

                while ((position < array.Length) && (array[position] != rand))
                {
                    position++;
                }

                if (position < array.Length)
                {
                    found = 1;
                    i -= 1;
                    position = 0;
                }

                else
                {
                    found = 0;
                    position = 0;
                }

                if(found == 0)
                {
                    array[i] = rand;
                }

            }

            return array;
        }
    }

    public class Program
    {

        public static void DisplayArray(int[] array)
        {
            foreach (int item in array)
            {
                Console.WriteLine(item.ToString());
            }
        }

        static void Main(string[] args)
        {

            DisplayArray(RandomArrayNoDuplicates.InitializeArrayWithNoDuplicates(20));
            Console.ReadLine();
        }
    }
}