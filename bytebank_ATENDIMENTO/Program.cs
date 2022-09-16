using bytebank.Modelos.Conta;
using bytebank_ATENDIMENTO.bytebank.Util;

Console.WriteLine("Boas Vindas ao ByteBank, Atendimento.");

// TestArrayInt();
//BuscarPalavra();


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

Array amostra = new double[5];
amostra.SetValue(5.9, 0);
amostra.SetValue(1.8, 1);
amostra.SetValue(7.1, 2);
amostra.SetValue(10.3, 3);
amostra.SetValue(6.9, 4);

//Mediana(amostra);

void Mediana(Array array)
{
    if ((array == null) || (array.Length == 0))
    {
        Console.WriteLine("Arra para cálculo de mediana está vazio ou nulo.");
    }

    double[] numerosOrdenados = (double[])array.Clone();
    Array.Sort(numerosOrdenados);

    int tamanho = numerosOrdenados.Length;
    int meio = tamanho / 2;
    double mediana = (tamanho % 2 != 0) ? numerosOrdenados[meio] : (numerosOrdenados[meio] + numerosOrdenados[meio - 1]) / 2;

    foreach (var item in numerosOrdenados)
    {
        Console.WriteLine($"Array ordenado: {item}");
    }

    Console.WriteLine($"Com base na amostra a mediana = {mediana}");
}


double[] amostragem = new double[4];

amostragem[0] = 3500;
amostragem[1] = 2600;
amostragem[2] = 2500;
amostragem[3] = 3400;

//MediaDaAmostra(amostragem);

double MediaDaAmostra(double[] amostra)
{
    double media;
    double acumulador = 0;

    if ((amostra == null) || (amostra.Length == 0))
    {
        Console.WriteLine("Amostra de dados nula ou vazia.");
        return 0;
    }
    else
    {
        for (int i = 0; i < amostra.Length; i++)
        {
            acumulador = acumulador + amostra[i];
        }
        media = acumulador / amostra.Length;
    }

    Console.WriteLine(media);
    return media;



}



void ArrayDeContasCorrentes()
{
    ListaDeContasCorrentes listaDeContas = new ListaDeContasCorrentes();
    listaDeContas.Adicionar(new ContaCorrente(123, "1111222-A"));
    listaDeContas.Adicionar(new ContaCorrente(234, "1111222-B"));
    listaDeContas.Adicionar(new ContaCorrente(456, "1111222-C"));
    listaDeContas.Adicionar(new ContaCorrente(456, "1111222-C"));
    listaDeContas.Adicionar(new ContaCorrente(456, "1111222-C"));
    listaDeContas.Adicionar(new ContaCorrente(456, "1111222-C"));
}

ArrayDeContasCorrentes();