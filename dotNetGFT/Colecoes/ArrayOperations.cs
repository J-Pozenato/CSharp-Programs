namespace Colecoes
{
    public class ArrayOperations
    {
        public void BubbleSort(ref int[] array)
        {
            Console.WriteLine("Original Array");
            PrintArray(array);
            
            int temp = 0;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        temp = array[j + 1];
                        array[j +1] = array[j];
                        array[j] = temp;
                    }
                }
            }

            Console.WriteLine("Sorted Array");
            PrintArray(array);
        }

        public void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine("");
        }

        public void SortSystem(ref int[] array)
        {
            Array.Sort(array);
        }

        
    }
}