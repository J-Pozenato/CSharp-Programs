ReadCsv();
// CreateCsv();

static void CreateCsv()
{
    var path = Path.Combine(Environment.CurrentDirectory,"out");

    var people = new List<Person>()
    {
        new Person()
        {
            name = "asiodnoa",
            email = "aoisj@aspoijkp.com",
            number = 12439,
            birth = new DateOnly(2001, 02, 12)
        },
        new Person()
        {
            name = "asdzxd",
            email = "aoasdwisj@aspoijkp.com",
            number = 12443439,
            birth = new DateOnly(2011, 12, 12)
        },
        new Person()
        {
            name = "vcvasd",
            email = "aowqeisj@aspoijkp.com",
            number = 1223439,
            birth = new DateOnly(2003, 5, 12)
        }
    };

    var dir = new DirectoryInfo(path);
    if(!dir.Exists)
    {
        dir.Create();
        path = Path.Combine(path, "usersOut.csv");
    }
    using var sw = new StreamWriter(path);
    sw.WriteLine("name,email,number,birth");
    foreach (var person in people)
    {
        var line = $"{person.name},{person.email},{person.number},{person.birth}";
        sw.WriteLine(line);
    }
}


static void ReadCsv()
{
    var path = Path.Combine(Environment.CurrentDirectory,"users.csv");

    if (File.Exists(path))
    {
        using var sr = new StreamReader(path);

        var header = sr.ReadLine()?.Split(',');

        while(true)
        {
            var reg = sr.ReadLine()?.Split(',');
            if(reg == null)
            {
                break;
            }
            if(header?.Length != reg.Length)
            {
                Console.WriteLine($"there is more or less data than in the header");
            }

            for (int i = 0; i < reg.Length; i++)
            {
                Console.WriteLine($"{header?[i]}: {reg[i]}");
            }

            Console.WriteLine("---------------");
        }

        Console.WriteLine("Press enter to close");
        Console.ReadLine();
    }
    else
    {
        Console.WriteLine("File doens't exist");
    }
}

class Person
{
    public string name {get;set;}
    public string email {get;set;}
    public int number {get;set;}
    public DateOnly birth {get;set;}

}







