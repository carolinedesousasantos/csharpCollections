class Program
{
    private static Queue<string> pedagio = new Queue<string>();
    
    public static void Main(string [] args)
    {
        Enfileirar("Van");
        Enfileirar("Kombi");
        Enfileirar("Guincho");
        Enfileirar("Pickup");

        Desenfileirar();
        Desenfileirar();
        Desenfileirar();
        Desenfileirar();
        Desenfileirar();
    }

    private static void Desenfileirar()
    {
        if (pedagio.Any())
        {
            if (pedagio.Peek() == "Guincho")
            {
                Console.WriteLine("Guincho está realizando o pagamento:");
            }
            var veiculo = pedagio.Dequeue();
            Console.WriteLine($"Saiu da fila: {veiculo}.");
            ImprimirFila();   
        }

    }

    private static void Enfileirar(string veiculo)
    {
        Console.WriteLine($"Entrou na fila: {veiculo}");
        pedagio.Enqueue(veiculo);
        ImprimirFila();
    }

    private static void ImprimirFila()
    {
        Console.WriteLine("Fila:");
        foreach (var v in pedagio)
        {
            Console.WriteLine(v);
        }
    }
}