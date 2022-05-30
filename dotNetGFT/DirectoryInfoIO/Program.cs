var path = @"F:\Csharp\dotNetGFT\DirectoryIO\globe";

// ReadDirectory(path);
ReadFiles(path);

Console.Write("Press enter to close....");
Console.ReadLine();

static void ReadFiles(string path)
{
    
    if (Directory.Exists(path))
    {
        var files = Directory.GetFiles(path,"*",SearchOption.AllDirectories);
        foreach (var file in files)
        {
            var fileInfo = new DirectoryInfo(file);
            Console.WriteLine($"[Nome]: {fileInfo.Name}");
            Console.WriteLine($"[root]: {fileInfo.Root}");
            Console.WriteLine($"[Last access]: {fileInfo.LastAccessTime}");
            if (fileInfo.Parent != null)
                Console.WriteLine($"[parent]: {fileInfo.Parent.Name}");
            Console.WriteLine($"[Folder]: {fileInfo.FullName}");

            Console.WriteLine("----------------------");

        }
    }
    else
    {
        Console.WriteLine($"{path} doesn't exist");
    }
    
}
static void ReadDirectory(string path)
{
    if (Directory.Exists(path))
    {
        var directories = Directory.GetDirectories(path,"*",SearchOption.AllDirectories);
        foreach (var dir in directories)
        {
            var dirInfo = new DirectoryInfo(dir);
            Console.WriteLine($"[Nome]: {dirInfo.Name}");
            Console.WriteLine($"[root]: {dirInfo.Root}");
            
            if (dirInfo.Parent != null)
                Console.WriteLine($"[parent]: {dirInfo.Parent.Name}");

            Console.WriteLine("----------------------");

        }
    }
    else
    {
        Console.WriteLine($"{path} doesn't exist");
    }

}