Console.WriteLine("Boas Vindas ao ByteBank, Atendimento.");

// TestArrayInt();
BuscarPalavra();

void TestArrayInt()
{
    int[] idades = new int[5];
    idades[0] = 30;
    idades[1] = 40;
    idades[2] = 17;
    idades[3] = 21;
    idades[4] = 18;

    Console.WriteLine($"Tamando do Aray: {idades.Length}");

    int acumulador = 0;
    for (int i = 0; i < idades.Length; i++)
    {
        int idade = idades[i];
        acumulador = acumulador + idade;
        Console.WriteLine($"Índice [{i}] = {idade}");
    }

    int media = acumulador / idades.Length;
    Console.WriteLine($"A média é = {media}");
}

void BuscarPalavra()
{
    string[] arrayDePalavras = new string[5];

    for (int i = 0; i < arrayDePalavras.Length; i++)
    {
        Console.Write($"Digite a {i + 1}ª palavra: ");
        arrayDePalavras[i] = Console.ReadLine();
    }

    Console.Write("Digite palavra a ser encontrada: ");
    var busca = Console.ReadLine();

    foreach (var palavra in arrayDePalavras)
    {
        if (palavra.Equals(busca))
        {
            Console.WriteLine($"Palavara encontrada = {busca}");
            return;
        }
        else
        {
            Console.WriteLine("Palavra não encontrada!");
            return;
        }
    }

}