
public class Program
{
    public static void Main()
    {
        Demo1();
        Demo2();
        Demo3();
        Demo4();
        Demo5();
        Demo6();
        Demo7();

    }

    static void Demo1()
    {
        Pessoa p1 = new Pessoa();
        p1.Nome = "Pedora";
        p1.Idade = 20;
        p1.Documento = "asiuhiu223";

        Console.WriteLine(p1.Nome);

        var p2 = p1.Clone();

        TrocarNome(p1, "Pedro");
        // como class é reference type vai funcionar tudo certo
        Console.WriteLine($@"
        Nome de p1: {p1.Nome}
        Nome de p2: {p2.Nome}
        ");
    }

    static void Demo2()
    {
        StructPessoa p1 = new StructPessoa{
            Documento = "124sfs",
            Idade = 14,
            Nome = "huidga"
        };

        StructPessoa p2 = p1;

        p1 = TrocarNome(p1, "Pedro");
        // structs são value type então precisa do return para alterar o valor
        Console.WriteLine($@"
        Nome de p1: {p1.Nome}
        Nome de p2: {p2.Nome}
        ");

    }

    static void Demo3()
    {
        string nome = "Pedroa";
        Console.WriteLine(nome);

        TrocarNome(nome, "huidga");

        Console.WriteLine(nome);
        // não troca pq string é value type no  C#

    }

    static void Demo4()
    {
        int[] pares = new int[]{0,2,4,6,8};
        Console.WriteLine(string.Join(",", pares));

        MudarParaImpar(pares);  
        Console.WriteLine(string.Join(",", pares));
        // como array é reference type vai funcionar tudo certo

    }

    static void Demo5()
    {
        int[] numeros = new int[]{0,2,4,6,8};

        Console.Write("Digite o numero que deseja encontrar: ");
        bool success = int.TryParse(Console.ReadLine(), out int numero);
        int indice;

        if (success)
        {
            indice = EncontrarNumero(numeros, numero);
        }
        else
        {
            Console.WriteLine(@"Erro, não foi possivel transformar em numero
            Exemplo de uso: Digite o numero que deseja encontrar: 8 ");
            return;
        }

        if (indice == -1)
        {
            Console.WriteLine($"O numero {numero} não foi encontrado no array");
        }
        else
        {
            Console.WriteLine($"O numero está na {indice}º posição do array");
        }
    }
    
    static void Demo6()
    {
        List<Pessoa> pessoas = new List<Pessoa>()
        {
            new Pessoa{Nome = "Pedro"},
            new Pessoa{Nome = "João"},
            new Pessoa{Nome = "Choco"},
            new Pessoa{Nome = "Brenda"},
            new Pessoa{Nome = "Pessoa"}
        };

        Pessoa procurado = new Pessoa();
        Console.Write("Digite o nome da pessoa procurada: ");
        procurado.Nome = Console.ReadLine();

        if (EncontrarPessoa(pessoas, procurado))
        {
            Console.WriteLine($"A pessoa {procurado.Nome} foi encontrada na nossa lista");
        }
        else
        {
            Console.WriteLine($"Não encontramos a pessoa {procurado.Nome}");
        }
    }

    static void Demo7()
    {
        int a = 2;

        Console.WriteLine($"Valor de a: {a}");

        Adicionar20(ref a);
        Console.WriteLine($"Valor de a: {a}");


    }

    static void Adicionar20(ref int a)
    {
        a += 20;

    }

    static bool EncontrarPessoa(List<Pessoa> pessoas, Pessoa encontrar)
    {
        string nome = encontrar.Nome.ToUpper();

        foreach (var pessoa in pessoas)
        {
            if (pessoa.Nome.ToUpper() == nome)
            {
                return true;
            }
        }
        return false;
    }

    static int EncontrarNumero(int[] encontrar, int numero)
    {
        for (int i = 0; i < encontrar.Length; i++)
        {
            if (encontrar[i] == numero)
            {
                return i;
            }
        }
        return -1;
    }
    static void MudarParaImpar(int[] pares)
    {
        for (int i = 0; i < pares.Length; i++)
        {
            pares[i]++;
        }
    }

    static void TrocarNome(string nome, string nomeNovo)
    {
        nome =  nomeNovo;
    }
    static void TrocarNome(Pessoa pessoa, string nome)
    {
        pessoa.Nome = nome;
    }

    static StructPessoa TrocarNome(StructPessoa pessoa, string nome)
    {
        pessoa.Nome = nome;
        return pessoa;
    }
}