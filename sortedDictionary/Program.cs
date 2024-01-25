    using A41Dicionarios;
    
    IDictionary<string,Aluno> sorted = new SortedDictionary<string, Aluno>();
    sorted.Add("VT", new Aluno("Vanessa", 34672));
    sorted.Add("AL", new Aluno("Ana", 5617));
    sorted.Add("RN", new Aluno("Rafael", 17645));
    sorted.Add("WM", new Aluno("Wanderson", 12345));
    sorted.Add("MS", new Aluno("Marcelo", 321));
    Console.WriteLine();
    foreach (var aluno in sorted)
    {
        Console.WriteLine(aluno);
    }