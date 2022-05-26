

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int[] arrayInt = new int[3];

arrayInt[0] = 10;
arrayInt[1] = 20;
arrayInt[2] = 30;

int [,] matrix = new int[3,3]
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

Console.WriteLine("matrix usingo for");
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write($"{matrix[i,j]} ");
    }
    Console.WriteLine("");
}

