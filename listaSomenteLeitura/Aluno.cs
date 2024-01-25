namespace listaSomenteLeitura;

public class Aluno
{
    public string Nome { get; }
    public int  NumeroMatricula { get;}

    public Aluno(string nome, int numeroMatricula)
    {
        Nome = nome;
        NumeroMatricula = numeroMatricula;
    }
    public override string ToString()
    {
        return $"[Nome: {Nome}, Matrícula: {NumeroMatricula}]";
    }

    public override bool Equals(object? obj)
    {
        Aluno outro = obj as Aluno;
        if (outro == null)
        {
            return false;
        }
        return Nome.Equals(outro.Nome);
    }

    public override int GetHashCode()
    {
        return Nome.GetHashCode();
    }
}