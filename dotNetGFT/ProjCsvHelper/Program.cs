using System.Globalization;
using CsvHelper;
using CsvHelper.Configuration;

// ReadCSVDynamic();
ReadCSVClass();

static void ReadCSVClass()
{
    var path = Path.Combine(Environment.CurrentDirectory,"users.csv");

    var fi = new FileInfo(path);

    if (!fi.Exists)
    {
        throw new FileNotFoundException($"File {path} not found");
    }

    var sr = new StreamReader(fi.FullName);
    var csvConfig = new CsvHelper.Configuration.CsvConfiguration(CultureInfo.InvariantCulture);
    using var csvReader = new CsvReader(sr, csvConfig);

    var regs = csvReader.GetRecords<User>();
    foreach (var reg in regs)
    {
        Console.WriteLine($"name: {reg.name}");
        Console.WriteLine($"Telefone number: {reg.number}");
        Console.WriteLine($"Email: {reg.email}");
        Console.WriteLine("------------------");

    }
}


static void ReadCSVDynamic()
{
    var path = Path.Combine(Environment.CurrentDirectory,"products.csv");

    var fi = new FileInfo(path);

    if (!fi.Exists)
    {
        throw new FileNotFoundException($"File {path} not found");
    }

    var sr =new StreamReader(fi.FullName);
    var csvConfig = new CsvHelper.Configuration.CsvConfiguration(CultureInfo.InvariantCulture);
    using var csvReader = new CsvReader(sr, csvConfig);

    var regs = csvReader.GetRecords<dynamic>();
    foreach (var reg in regs)
    {
        Console.WriteLine($"name: {reg.name}");
        Console.WriteLine($"brand: {reg.brand}");
        Console.WriteLine($"price: {reg.price}");
        Console.WriteLine("------------------");

    }
}
