using System.Text;
var sb = new StringBuilder();
sb.AppendLine("line1");
sb.AppendLine("line2");
sb.AppendLine("line3");

using var sr = new StringReader(sb.ToString());

// read without buffer
// var text = sr.ReadToEnd();
// Console.WriteLine(text);

// read with buffer
var buffer = new char[10];
var tamanho = 0;

do
{
    buffer = new char[10];
    tamanho = sr.Read(buffer);
    Console.Write($"{string.Join("",buffer)}");

} while (tamanho >= buffer.Length);


