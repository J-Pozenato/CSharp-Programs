
public class Program
{
    public static void Main()
    {
        Pessoa p1 = new Pessoa();
        p1.Nome = "Pedora";
        p1.Idade = 20;
        p1.Documento = "asiuhiu223";

        Console.WriteLine(p1.Nome);

        TrocarNome(p1, "Pedro");

        Console.WriteLine(p1.Nome);

    }

    static void TrocarNome(Pessoa pessoa, string nome)
    {
        pessoa.Nome = nome;
    }
}