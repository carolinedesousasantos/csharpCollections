namespace listaSomenteLeitura;

public class Aula: IComparable
{
    public string Titulo { get; set; }
    public int Tempo { get; set; }

    public Aula(string titulo, int tempo)
    {
        Titulo = titulo;
        Tempo = tempo;
    }

    public override string ToString()
    {
        return $"[título: {Titulo}, tempo: {Tempo} minutos]";
    }

    public int CompareTo(object? obj)
    {
        Aula that = obj as Aula;
        return Titulo.CompareTo(that.Titulo);
    }
}