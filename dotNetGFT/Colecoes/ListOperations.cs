namespace Colecoes
{
    public class ListOperations
    {
        public void PrintStringList(List<string> list)
        {
            for (int i = 0; i < list.Count; i++)
                {
                    System.Console.WriteLine($"Index: {i}  Content: {list[i]}");
                }
        }
    }
}