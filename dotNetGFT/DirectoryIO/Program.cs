

CreateDirectoryGlobe();
CreateFile();

var source = Path.Combine(Environment.CurrentDirectory, "Data.txt");
var dest = Path.Combine(Environment.CurrentDirectory, "globe","North America","Canada", "Data.txt");
MoveFile(source, dest);
CopyFile(source, dest);

static void CopyFile(string pathSource, string pathDest)
{
    if (!File.Exists(pathSource))
    {
        Console.WriteLine("File not found");
        return;
    }
    
    if (File.Exists(pathDest))
    {
        Console.WriteLine("File already exists in the destination");
        return;
    }
    File.Copy(pathSource, pathDest);
}

static void MoveFile(string pathSource, string pathDest)
{
    if (!File.Exists(pathSource))
    {
        Console.WriteLine("File not found");
        return;
    }
    
    if (File.Exists(pathDest))
    {
        Console.WriteLine("File already exists in the destination");
        return;
    }

    File.Move(pathSource, pathDest);
}
static void CreateFile()
{
    var path = Path.Combine(Environment.CurrentDirectory, "Data.txt");
    if (!File.Exists(path))
    {
        using var sw = File.CreateText(path);
        sw.WriteLine("Population: XXXXM");
        sw.WriteLine("IDH: X.XX");
        sw.WriteLine("Updated in: XX/XX/XX");


    }
    
}
static void CreateDirectoryGlobe()
{
    var path = Path.Combine(Environment.CurrentDirectory, "globe");

    if (!Directory.Exists(path))
    {
        var dirGlobe = Directory.CreateDirectory(path);
        var dirNorthAm = dirGlobe.CreateSubdirectory("North America");
        var dirSouthAm = dirGlobe.CreateSubdirectory("South America");
        var dirCentralAm = dirGlobe.CreateSubdirectory("Central America");

        dirNorthAm.CreateSubdirectory("USA");
        dirNorthAm.CreateSubdirectory("Canada");
        dirNorthAm.CreateSubdirectory("Mexico");

        dirCentralAm.CreateSubdirectory("Costa Rica");
        dirCentralAm.CreateSubdirectory("Panama");

        dirSouthAm.CreateSubdirectory("Brazil");
        dirSouthAm.CreateSubdirectory("Argentina");
    }
}
