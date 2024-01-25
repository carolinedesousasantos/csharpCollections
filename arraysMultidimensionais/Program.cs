// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


string[,] resultados = new string[4, 3];
// {
//     {"Alemanha", "Espanha", "Itália"},
//     {"Argentina", "Holanda", "França"},
//     {"Holanda", "Alemanha", "Alemanha"}
// };

resultados[0, 0] = "Alemanha";
resultados[1, 0] = "Argentina";
resultados[2, 0] = "Holanda";
resultados[3, 0] = "Brasil";

resultados[0, 1] = "Espanha";
resultados[1, 1] = "Holanda";
resultados[2, 1] = "Alemanha";
resultados[3, 1] = "Uruguai";

resultados[0, 2] = "Itália";
resultados[1, 2] = "França";
resultados[2, 2] = "Alemanha";
resultados[3, 2] = "Portugal";
// foreach (var selecao in resultados)
// {
//     Console.WriteLine(selecao); 
// }

for (int copa = 0; copa <= resultados.GetUpperBound(1); copa++)
{
    int ano = 2014 - copa * 4;
    Console.Write(ano.ToString().PadRight(12));
}
Console.WriteLine();

for (int posicao = 0;posicao <= resultados.GetUpperBound(0); posicao++)
{
    for (int copa = 0; copa <= resultados.GetUpperBound(1); copa++)
    {
        Console.Write(resultados[posicao, copa].PadRight(12));
    }
    Console.WriteLine();
}

Console.WriteLine();
Console.WriteLine("Tabuleiro ");
char[,] tabuleiro = new char[3,3];
tabuleiro[0, 0] = 'X';
tabuleiro[1, 0] = '.';
tabuleiro[2, 0] = 'O';
tabuleiro[0, 1] = 'X';
tabuleiro[1, 1] = 'X';
tabuleiro[2, 1] = 'O';
tabuleiro[0, 2] = '.';
tabuleiro[1, 2] = 'O';
tabuleiro[2, 2] = 'X';

for(var y = 0; y < 3; y++)
{
    for(var x = 0; x < 3; x++)
    {
        Console.Write(tabuleiro[x,y]);
    }
    Console.WriteLine();
}