namespace FileIO
{
    public class Program
    {
        public static void Main()
        {
            
            Console.WriteLine("Enter the File name: ");
            var name = Console.ReadLine();

            if (String.IsNullOrEmpty(name))
            {
                name = "default";
            }
            
            name = RemoveInvalidChars(name);

            var path = Path.Combine(Environment.CurrentDirectory, $"{name}.txt");
            
            CreateFile(path);

            Console.WriteLine("Press enter to close");
            Console.ReadLine();


            static string RemoveInvalidChars(string name)
            {
                foreach (var character in Path.GetInvalidFileNameChars())
                {
                    name = name.Replace(character, '-');
                }
                
                return name;
            }
            static void CreateFile(string path)
            {
                try
                {
                    using var sw = File.CreateText(path);

                    sw.WriteLine("line1");
                    sw.WriteLine("line2");
                    sw.WriteLine("line3");
                }
                catch
                {
                    Console.WriteLine("Invalid file name");
                }

            }


        }

    } 
}