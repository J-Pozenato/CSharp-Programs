var path = @"F:\Csharp\dotNetGFT\DirectoryIO\globe";
using var fsw = new FileSystemWatcher(path);

fsw.Created += OnCreated;
fsw.Created += OnDeleted;
fsw.Created += OnRenamed;


fsw.EnableRaisingEvents = true;
fsw.IncludeSubdirectories = true;

Console.WriteLine(@"Watching the folder  F:\Csharp\dotNetGFT\DirectoryIO\globe ");
Console.WriteLine("Press Enter to stop and close");

Console.ReadLine();

void OnCreated(object sender, FileSystemEventArgs e)
{
    Console.WriteLine($"A file was created : {e.Name}");
}


void OnDeleted(object sender, FileSystemEventArgs e)
{
    Console.WriteLine($"A file was Deleted : {e.Name}");

}


void OnRenamed(object sender, FileSystemEventArgs e)
{
    Console.WriteLine($"A file was Renamed : {e.Name}");
}