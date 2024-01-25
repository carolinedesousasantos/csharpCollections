using listaSomenteLeitura;

class Program
{
    public static void Main(string[] args)
    {
        // ReadOnlyExample();
        // HasSetExamples();
        DictionaryExamples();
    }

    public static void DictionaryExamples()
    {
        Curso csharpColecoes = new Curso("C# Colecoes", "Marcelo Oliveira");
        csharpColecoes.Adiciona(new Aula("Trabahando com Listas", 21));
        csharpColecoes.Adiciona(new Aula("Criando uma Aula", 20));
        csharpColecoes.Adiciona(new Aula("Modelando com Coleçoes", 24));
        
        Aluno a1 = new("Vanessa", 34672);
        Aluno a2 = new("Ana", 5617);
        Aluno a3 = new("Rafael", 17645);

        csharpColecoes.Matricula(a1);
        csharpColecoes.Matricula(a2);
        csharpColecoes.Matricula(a3);
        
        Console.WriteLine("Imprimindo alunos matriculados");
        foreach (var aluno in csharpColecoes.Alunos)
        {
            Console.WriteLine(aluno.ToString());
            Console.WriteLine(aluno.GetHashCode());
        }

        Console.WriteLine($"O aluno a1 {a1.Nome} está matriculado?");
        Console.WriteLine(csharpColecoes.EstaMatriculado(a1));

        Aluno vanessa = new("Vanessa", 34672);
        Console.WriteLine("Vanessa está matriculada?" + csharpColecoes.EstaMatriculado(vanessa));
        Console.WriteLine("a1 == Vanessa?");
        Console.WriteLine(a1 == vanessa);
        Console.WriteLine(a1.Equals(vanessa));

        Aluno aluno5617 = csharpColecoes.BuscaMatriculado(5617);
        Console.WriteLine($"aluno5617: {aluno5617}");

        Console.WriteLine("Quem é o aluno 5618");
        Aluno aluno5618 = csharpColecoes.BuscaMatriculado(5618);
        Console.WriteLine($"aluno5618: {aluno5618}");

        // Nao aceita chave repetida
        Aluno fabio = new("Fabio", 5617);
        // csharpColecoes.Matricula(fabio);

        csharpColecoes.SubstituiAluno(fabio);
        Console.WriteLine("Quem é o aluno 5617 agora?");
        Console.WriteLine(csharpColecoes.BuscaMatriculado(5617));
    }
    public static  void ReadOnlyExample()
    {
        Curso csharpColecoes = new Curso("C# Collections", "Marcelo Oliveira");
        csharpColecoes.Adiciona(new Aula("Trabalhando com Listas", 21));
        csharpColecoes.Adiciona(new Aula("Criando uma aula", 20));
        csharpColecoes.Adiciona(new Aula("Modelando com colecoes", 15));
        Imprimir(csharpColecoes.Aulas);

        List<Aula> aulasCopiadas = new List<Aula>(csharpColecoes.Aulas);
        aulasCopiadas.Sort();
        Imprimir(aulasCopiadas);

        //totalizar tempo do curso
        Console.WriteLine(csharpColecoes.TempoTotal);

        // imprimir detalhes
        Console.WriteLine(csharpColecoes.ToString());
    }
 
    public static void HasSetExamples()
    {
        ISet<string> alunos = new HashSet<string>();
        alunos.Add("Vanessa Tionini");
        alunos.Add("Ana Losnak");
        alunos.Add("Rafael Necerssian");
        Console.WriteLine(string.Join(",", alunos));
        Console.WriteLine();
        
        alunos.Add("Priscila Stuani");
        alunos.Add("Rafael Rollo");
        alunos.Add("Fabio Gushiken");
        Console.WriteLine(string.Join(",", alunos));
        Console.WriteLine();
        
        alunos.Remove("Ana Losnak");
        alunos.Add("Marcelo Oliveira");
        Console.WriteLine(string.Join(",", alunos));
        Console.WriteLine();

        // Um HashSet nao aceita valores repetidos
        alunos.Add("Fabio Gushiken");
        Console.WriteLine(string.Join(",", alunos));
        Console.WriteLine();

        // Uma lista aceita valores repetidos
        List<string> copia = new List<string>(alunos);
        copia.Add("Fabio Gushiken");
        copia.Sort();
        Console.WriteLine(string.Join(",", copia));
    }
    
    private static void Imprimir(IList<Aula> aulas)
    {
        Console.Clear();
        foreach( Aula aula in aulas )
        {
            Console.WriteLine(aula);
        }
    }

}
