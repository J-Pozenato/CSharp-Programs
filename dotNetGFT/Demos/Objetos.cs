public ref struct Pessoa2
{
    public int Idade {get; set;}
    public string Nome {get; set;}
    public string Documento {get; set;}

    public Endereco EnderecoPessoa {get; set;}

}
public ref struct Endereco
{
    public int Numero {get; set;}
    public string Logradouro {get; set;}
    public string CEP { get; set; }
    public string Cidade {get; set; }

}

public class Numero
{
    public int N {get; set;}

    public Numero(int n)
    {
        N = n;
    }
}
