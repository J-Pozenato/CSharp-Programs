string textReaderText = @"iasubfisabipduashipufhiovnjchnuip
                        jkcnjkoqsbhi iusabiubucnini


                          uihsani nb c9qaniuf 
                          
                        
                        ashfiunsdji";

Console.WriteLine("Original text");
Console.WriteLine(textReaderText);

string linha, paragrafo = null;
var sr = new StringReader(textReaderText);

while (true)
{
    linha = sr.ReadLine();
    if (linha != null)
    {
        paragrafo += linha + " ";
    }
    else
    {
        paragrafo += "\n";
        break;
    }
}

Console.WriteLine("Modified text");

Console.WriteLine(paragrafo);
int charRead;
char charConverted;

var sw = new StringWriter();
sr = new StringReader(paragrafo);

while(true)
{
    charRead = sr.Read();
    if(charRead == -1)
    {
        break;
    }

    charConverted = Convert.ToChar(charRead);

    if(charConverted == '.')
    {
        sw.Write("\n\n");

        sr.Read();
        sr.Read();
    }
    else
    {
        sw.Write(charConverted);

    }
}

Console.WriteLine($"Text stored in StringWriter: {sw.ToString()}");
