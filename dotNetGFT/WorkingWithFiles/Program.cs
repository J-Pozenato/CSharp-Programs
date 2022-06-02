
using WorkingWithFiles.Helper;

var path = Path.Combine(Environment.CurrentDirectory);
FileHelper helper = new FileHelper();

Console.WriteLine("List of Folders and subFolders");
helper.ListDirectories(path);

Console.WriteLine("--------------------------------------\n\nList of Files in Folders and SubFolders");
helper.ListFileDirectories(path);

Console.WriteLine("-------------------------\n\nCreate new Folder");
helper.CreateDirectory(Path.Combine(path,"createdFolder", "createdSubFolder"));
Console.WriteLine("Press Enter to continue");
Console.ReadLine(); // wait for enter press

Console.WriteLine("------------------------------------\n\nDeleting Folder");
helper.DeleteDirecotory(Path.Combine(path,"createdFolder", "createdSubFolder"), false);

Console.WriteLine("--------------------------------------------\n\nCreate TextFile");
helper.CreateFileText(Path.Combine(path,"text.txt"),"textteste textest");

Console.WriteLine("----------------------------------\n\nCreate TextFile with stream");
var listString = new List<string> { "line1","line2","line3"};
helper.CreateFileTextStream(Path.Combine(path,"testStream.txt"),listString);

Console.WriteLine("-----------------------------------\n\nAdd text to existing file");
helper.AddText(Path.Combine(path,"text.txt"),"Addtext");

Console.WriteLine("-----------------------------------\n\nAdd text to existing file with stream");
var addListString = new List<string> { "addline1","addline2","addline3"};
helper.AddTextStream(Path.Combine(path,"testStream.txt"),addListString);

Console.WriteLine("----------------------------------\n\nRead File with stream");
helper.ReadFileStream(Path.Combine(path,"testStream.txt"));

Console.WriteLine("----------------------------------\n\nMove file");
helper.MoveFile(Path.Combine(path,"testStream.txt"), Path.Combine(path,"Test1","testStream.txt"), true);

Console.WriteLine("-----------------------------------\n\nCopy File");
helper.CopyFile(Path.Combine(path,"text.txt"), Path.Combine(path,"Test2","textBackup.txt"), true);