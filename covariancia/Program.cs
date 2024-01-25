Console.WriteLine("string para object");
string titulo = "meses";
object obj = titulo;
Console.WriteLine(obj);

Console.WriteLine("List<string> para List<object>");
IList<string> listaMeses = new List<string>
{
    "Janeiro", "Fevereiro", "Março",
    "Abril", "Maio", "Junho",
    "Julho", "Agosto", "Setembro",
    "Outubro", "Novembro", "Dezembro"
};
// IList<object> listaObj = listaMeses;
Console.WriteLine();
Console.WriteLine("string[] para object[]");

string[] arrayMeses = new string[]
{
    "Janeiro", "Fevereiro", "Março",
    "Abril", "Maio", "Junho",
    "Julho", "Agosto", "Setembro",
    "Outubro", "Novembro", "Dezembro"
};

// A covariância do array deve ser evitada sempre!
object[] arrayObj = arrayMeses; //Covariância
Console.WriteLine(arrayObj);
foreach (var item in arrayObj)
{
    Console.WriteLine(item);
}

Console.WriteLine();
arrayObj[0] = "Primeiro mês";
Console.WriteLine(arrayObj[0]);
Console.WriteLine();


// arrayObj[0] = 1234;
// Console.WriteLine(arrayObj[0]);
// Console.WriteLine();

Console.WriteLine("List<string> para IEnumerable<object>");
IEnumerable<object> enumObj = listaMeses; // Covariância
foreach (var item in enumObj)
{
    Console.WriteLine(item);
}

Console.WriteLine();