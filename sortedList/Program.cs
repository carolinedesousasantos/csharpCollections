﻿    using A41Dicionarios;
    
    Console.WriteLine("aqui");
IDictionary<string, Aluno> alunos = new Dictionary<string, Aluno>();
alunos.Add("VT", new Aluno("Vanessa", 34672));
alunos.Add("AL", new Aluno("Ana", 5617));
alunos.Add("RN", new Aluno("Rafael", 17645));
alunos.Add("WM", new Aluno("Wanderson", 12345));

foreach (var aluno in alunos)
{
    Console.WriteLine(aluno);
}

alunos.Remove("AL");
alunos.Add("MS", new Aluno("Marcelo", 321));
Console.WriteLine();
foreach (var aluno in alunos)
{
    Console.WriteLine(aluno);
}

Console.WriteLine("********************************+");

IDictionary<string,Aluno> sorted = new SortedList<string, Aluno>();
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