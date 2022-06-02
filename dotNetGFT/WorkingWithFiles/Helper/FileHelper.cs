namespace WorkingWithFiles.Helper
{
    public class FileHelper
    {
       public void ListDirectories(string path)
       {
           var returnPath = Directory.GetDirectories(path, "*", SearchOption.AllDirectories);

           foreach (var returned in returnPath)
           {
               Console.WriteLine(returned);
           }
       }

       public void ListFileDirectories(string path)
       {
           var returnFiles = Directory.GetFiles(path, "*", SearchOption.AllDirectories);

           foreach (var returned in returnFiles)
           {
               Console.WriteLine(returned);
           }
       }

       public void CreateDirectory(string path)
       {
           var returnedPath = Directory.CreateDirectory(path);
           Console.WriteLine(returnedPath);
       }

       public void DeleteDirecotory(string path, bool deleteFiles)
       {
           Directory.Delete(path, deleteFiles);
       }

       public void CreateFileText(string path,string text)
       {
           if (!File.Exists(path))
           {
               File.WriteAllText(path,text);
                Console.WriteLine($"file Created on {path}");
           }
           else
           {
               Console.WriteLine($"File already exists on {path}");
           }
       }

       public void CreateFileTextStream(string path, List<string> text)
       {
           using var stream = File.CreateText(path);
        
           foreach (var line in text)
           {
               stream.WriteLine(line);
           }
       }

       public void AddText(string path,string text)
       {
           File.AppendAllText(path, text);
       }

        public void AddTextStream(string path, List<string> text)
       {
           using var stream = File.AppendText(path);
        
           foreach (var line in text)
           {
               stream.WriteLine(line);
           }
       }

        public void ReadFile(string path)
        {
            var content = File.ReadAllLines(path);

                foreach (var line in content)
                {
                    Console.WriteLine(line);
                }
        }

        public void ReadFileStream(string path)
        {
            string line = string.Empty;

            using var stream = File.OpenText(path);

            while ((line = stream.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }

        public void MoveFile(string source, string destination, bool overwrite)
        {
            File.Move(source, destination, overwrite);
        }

        public void CopyFile(string path, string newPath, bool overwrite)
        {
            File.Copy(path, newPath, overwrite);
        }
    }
}