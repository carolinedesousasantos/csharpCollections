    ISet<string> alunos = new SortedSet<string>(new ComparadorMinuscula())
    {
        "Vanessa",
        "Ana",
        "Rafael",
        "Priscila"
    };
alunos.Add("Rafael");
alunos.Add("Fabio");
alunos.Add("Fabio");
alunos.Add("FABIO");

foreach (var aluno in alunos)
{
    Console.WriteLine(aluno);
}

ISet<string> outroConjunto = new HashSet<string>()
{
    "Maria",
    "Ana",
    "Joao",
    "Pedro"
};

Console.WriteLine("IsSubsetOf: " +alunos.IsSubsetOf(outroConjunto));
Console.WriteLine("IsSupersetOf: " +alunos.IsSupersetOf(outroConjunto));
Console.WriteLine("SetEquals: " +alunos.SetEquals(outroConjunto));
alunos.SymmetricExceptWith(outroConjunto);
    alunos.UnionWith(outroConjunto);

    foreach (var aluno in alunos)
    {
        Console.WriteLine(aluno);
    }
    public class ComparadorMinuscula : IComparer<string>
{
    public int Compare(string x, string y)
    {
        return string.Compare(x, y, StringComparison.OrdinalIgnoreCase);
    }
}