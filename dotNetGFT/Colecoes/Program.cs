using System.Collections.Generic;

namespace Colecoes
{
    public class Program
    {
        private static void Main(string[] args)
        {
            ArraysDemo();
            // ListsDemo();
            // QueueDemo();
            // StackDemo();
            // DictDemo();
            // LINQDemo();

            void LINQDemo()
            {
                int[] arrayNumbers = new int[9]{1, 4, 1, 4, 8, 15, 19, 100, 0};

                var evenNumbersQuery = 
                    from num in arrayNumbers
                    where num % 2 == 0
                    orderby num
                    select num;

                var evenNumbersMethod = arrayNumbers.Where(x => x % 2 == 0).OrderBy(x => x).ToList();

                Console.WriteLine($"Even Numbers Query: {string.Join(", ", evenNumbersQuery)}");
                Console.WriteLine($"Even Numbers Method: {string.Join(", ", evenNumbersMethod)}");

                var min = arrayNumbers.Min();
                var max = arrayNumbers.Max();
                var avg = arrayNumbers.Average();
                var sum = arrayNumbers.Sum();
                var arrayDistinct = arrayNumbers.Distinct().ToArray();

                Console.WriteLine($"Min : {min}");
                Console.WriteLine($"Max : {max}");
                Console.WriteLine($"Average : {avg}");
                Console.WriteLine($"Sum : {sum}");
                Console.WriteLine($"Array : {string.Join(", ", arrayNumbers)}");
                Console.WriteLine($"Distinct Array : {string.Join(", ", arrayDistinct)}");



                
            
            }

            void DictDemo()
            {
                Dictionary<string, string> dict1 = new Dictionary<string, string>();

                dict1.Add("Choco", "Dog");
                dict1.Add("Neko", "Cat");
                dict1.Add("Loro", "Parrot");
                dict1.Add("Cookie", "Dog");
                // EXCEPTION : An item with the same key has already been added. Key: Choco
                // dict1.Add("Choco", "mei");

                foreach (KeyValuePair<string, string> item in dict1)
                {
                    Console.WriteLine($"Key: {item.Key} Value: {item.Value}");
                }

                Console.WriteLine(dict1["Choco"]);
                // EXCEPTION : The given key '234s' was not present in the dictionary.
                // Console.WriteLine(dict1["234s"]);

                Console.WriteLine($"Valeu of Loro: {dict1["Loro"]}");
                dict1["Loro"] = "Bird";
                Console.WriteLine($"Valeu of Loro after change: {dict1["Loro"]}");

                Console.WriteLine($"Removing {dict1["Cookie"]}");
                dict1.Remove("Cookie");

                foreach (KeyValuePair<string, string> item in dict1)
                {
                    Console.WriteLine($"Key: {item.Key} Value: {item.Value}");
                }

                string findKey = "HUdig";
                if (dict1.TryGetValue(findKey, out string foundValue))
                {
                    Console.WriteLine($"Value: {foundValue}");
                }
                else
                {
                    Console.WriteLine($"Could not find any value for the key {findKey}");
                }

            }

            void StackDemo()
            {
                Stack<string> stack = new Stack<string>();

                stack.Push("uash");
                stack.Push("u23h");
                stack.Push("u564h");
                stack.Push("u1dfx");

                Console.WriteLine($"size of stack: {stack.Count}");
                while (stack.Count > 0)
                {
                    Console.WriteLine($"Next item to pop: {stack.Peek()}");
                    stack.Pop();
                }
                Console.WriteLine($"size of stack: {stack.Count}");

                
            }
            void QueueDemo()
            {
                Queue<string> queue = new Queue<string>();
                queue.Enqueue("pie");
                queue.Enqueue("sac");
                queue.Enqueue("24fv");
                queue.Enqueue("cvhr5");
                queue.Enqueue("pdst4");

                Console.WriteLine($"Queue size: {queue.Count}");
                while (queue.Count > 0)
                {
                    Console.WriteLine($"remove {queue.Peek()}");
                    queue.Dequeue();
                }
                Console.WriteLine($"Queue size: {queue.Count}");


            }

            void ListsDemo()
            {
                List<string> states = new List<string>();
                string[] statesArray = new string[4]{"SP", "MG", "PR", "SC"};
                // states.Add("SP");
                // states.Add("PR");
                // states.Add("SC");
                states.AddRange(statesArray);

                System.Console.WriteLine($"Number of elements in states: {states.Count}");

                ListOperations ListOp = new ListOperations();

                ListOp.PrintStringList(states);

                Console.WriteLine("removing SP state");
                states.Remove("SP");
                ListOp.PrintStringList(states);

                Console.WriteLine("removing all elements");
                states.RemoveAll(element => element.Length > 1);
                ListOp.PrintStringList(states);



            }
            void ArraysDemo()
            {
                int[] arrayInt = new int[3];

                arrayInt[0] = 10;
                arrayInt[1] = 20;
                arrayInt[2] = 30;

                // outside of bounds exception
                // Console.WriteLine(arrayInt[3]); 

                int[,] matrix = new int[3, 3]
                {
                    {1, 2, 3},
                    {4, 5, 6},
                    {7, 8, 9}
                };

                Console.WriteLine("array using for");
                for (int i = 0; i < arrayInt.Length; i++)
                {
                    Console.WriteLine(arrayInt[i]);
                }

                Console.WriteLine("array using foreach");
                foreach (var item in arrayInt)
                {
                    Console.WriteLine(item);

                }

                Console.WriteLine("matrix using for");
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        Console.Write($"{matrix[i, j]} ");
                    }
                    Console.WriteLine("");
                }

                int[] sort = new int[6] { 4, 56, 2, 3, 6, 1 };
                int[] copy = new int[10];

                ArrayOperations ArrayOp = new ArrayOperations();
                // testing the code for bubbleSort
                // ArrayOp.BubbleSort(ref sort);

                //testing the system.Array
                // ArrayOp.SortSystem(ref sort);
                // ArrayOp.PrintArray(sort);

                // Array.Copy(sort, copy, sort.Length);
                // ArrayOp.PrintArray(copy);

                bool exists = Array.Exists(sort, match => match == 2);

                if (exists)
                {
                    Console.WriteLine("Exists");
                }
                else
                {
                    Console.WriteLine("Doenst exist");
                }

                bool trueForAll = Array.TrueForAll(sort, match => match > 2);

                if (trueForAll)
                {
                    Console.WriteLine("All are higher");
                }
                else
                {
                    Console.WriteLine("Not all are higher");
                }

                Console.WriteLine(Array.FindIndex(sort, match => match == 1));

                Array.Resize(ref sort, 8);
                Console.WriteLine($"New Array size: {sort.Length}");
                ArrayOp.PrintArray(sort);

                string[] str = Array.ConvertAll(sort, element => element.ToString());


            }
            
       }
    }
}
