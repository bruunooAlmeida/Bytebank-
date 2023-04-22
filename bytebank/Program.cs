using bytebank.Contas;
using System.Numerics;


Console.WriteLine("Boas Vindas ao ByteBank, Atendimento.");
Array amostra = Array.CreateInstance(typeof(double), 5);
amostra.SetValue(5.9, 0);
amostra.SetValue(1.8, 1);
amostra.SetValue(7.1, 2);
amostra.SetValue(10, 3);
amostra.SetValue(6.9, 4);

double[] valores = { 10.5, 4.6, 7.9, 22.43 };

void TestaPosicaoArray()
{
    int[] valores = { 10, 58, 36, 47 };
    for (int i = 0; i < 5; i++)
    {
        Console.WriteLine(valores[i]);
    }
}

Console.WriteLine(calcularMedia(valores));

double calcularMedia(double[] amostras)
{
    double total = 0;

    foreach (double elemento in amostras)
    {
        Console.WriteLine(elemento);
        total += elemento;
    }

    return total;
}

//try
//{
//    TestaPosicaoArray();
//}
//catch(IndexOutOfRangeException e)
//{
//    Console.WriteLine(e.StackTrace);
//    Console.WriteLine(e.Message);
//}

void TestaMediana(Array array)
{
    if ((array == null) || (array.Length == 0))
    {
        Console.WriteLine("Array para cálculo da mediana está vazio ou nulo.");
    }

    double[] numerosOrdenados = (double[])array.Clone();
    Array.Sort(numerosOrdenados);
    //[1,8][5,9][6,9][7,1][10]

    int tamanho = numerosOrdenados.Length;
    int meio = tamanho / 2;
    double mediana = (tamanho % 2 != 0) ? numerosOrdenados[meio] :
                     (numerosOrdenados[meio] + numerosOrdenados[meio - 1]) / 2;
    Console.WriteLine($"Com base na amostra a mediana = {mediana}");
}

//TestaMediana(amostra);

//TestaBuscarPalavra();
void TestaBuscarPalavra()
{
    string[] arrayDePalavras = new string[5];

    for (int i = 0; i < arrayDePalavras.Length; i++)
    {
        Console.Write($"Digite {i + 1}ª Palavra: ");
        arrayDePalavras[i] = Console.ReadLine();
    }

    Console.Write("Digite palavra a ser encontrada: ");
    var busca = Console.ReadLine();

    foreach (string palavra in arrayDePalavras)
    {
        if (palavra.Equals(busca))
        {
            Console.WriteLine($"Palavra encontrada = {busca}.");
            break;
        }
    }
}

void TestaArrayContasCorrentes()
{

}