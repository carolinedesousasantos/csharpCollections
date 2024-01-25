class Program
{
    public static void Main(string[] args)
    {
        // ConsultaComMeses();
        
        string[] seq1 = { "janeiro", "fevereiro", "março" };
        string[] seq2 = { "fevereiro", "MARÇO", "abril"};

        Console.WriteLine("Concatenando duas sequências:");
        var consulta = seq1.Concat(seq2);
        foreach (var item in consulta)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();
        
        Console.WriteLine("Uniao de duas sequências:");
        var consulta2 = seq1.Union(seq2);
        foreach (var item in consulta2)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();
        
        Console.WriteLine("Uniao de duas sequências com comparador:");
        var consulta3 = seq1.Union(seq2, StringComparer.OrdinalIgnoreCase);
        foreach (var item in consulta3)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();
        
        Console.WriteLine("Interseçao de duas sequências:");
        var consulta4 = seq1.Intersect(seq2);
        foreach (var item in consulta4)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();
        
        Console.WriteLine("Exceto: elementos de seq1 que nao estao em seq2.");
        var consulta5 = seq1.Except(seq2);
        foreach (var item in consulta5)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();
    }

    public static void ConsultaComMeses()
    { 
        List<Mes> meses = new List<Mes>
        {
            new Mes("Janeiro", 31),
            new Mes("Fevereiro", 28),
            new Mes("Março", 31),
            new Mes("Abril", 30),
            new Mes("Maio", 31),
            new Mes("Junho", 30),
            new Mes("Julho", 31),
            new Mes("Agosto", 31),
            new Mes("Setembro", 30),
            new Mes("Outubro", 31),
            new Mes("Novembro", 30),
            new Mes("Dezembro", 31)
        };
        // meses.Sort();
        // foreach (var mes in meses)
        // {
        //  Console.WriteLine(mes.Nome.ToUpper());
        // }

        //LINQ = Consulta integrada à linguagem.
        
        IEnumerable<string> consulta = meses
            .Where(m=> m.Dias == 31)
            .OrderBy(m=> m.Nome)
            .Select(m=> m.Nome.ToUpper());
        
        foreach (var item in consulta)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();

        Console.WriteLine("EPgar o primeiro trimestre");
        IEnumerable<Mes> consulta1 = meses.Take(3);

        foreach (var item in consulta1)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();

        Console.WriteLine("Pular o primeiro trimestre");
        IEnumerable<Mes> consulta2 = meses.Skip(3);
        foreach (var item in consulta2)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();

        Console.WriteLine("Pegar o terceiro trimestre");
        IEnumerable<Mes> consulta3 = meses.Skip(6).Take(3);
        foreach (var item in consulta3)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();
        
        Console.WriteLine("Pegar os meses até que o mês começe com a letra 'S'");
        IEnumerable<Mes> consulta4 = meses.TakeWhile(m=> !m.Nome.StartsWith('S'));
        foreach (var item in consulta4)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();
        
        Console.WriteLine("Pular os meses até que o mês começe com a letra 'S'");
        IEnumerable<Mes> consulta5 = meses.SkipWhile(m=> !m.Nome.StartsWith('S'));
        foreach (var item in consulta5)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();
    }
    class Mes
    {
        public Mes(string nome, int dias)
        {
            Nome = nome;
            Dias = dias;
        }
        
        public string Nome { get; private set; }
        public int Dias { get; private set; }

        public override string ToString()
        {
            return $"{Nome} - {Dias}";
        }

        // public int CompareTo(object? obj)
        // {
        //     Mes outro = obj as Mes;
        //     return Nome.CompareTo(outro.Nome);
        // }
    }
}