using bytebank.Contas;
using bytebank.Exception;
using bytebank.Util;
using System.Collections;
using System.Drawing;
using System.Linq;
using System.Numerics;


Console.WriteLine("Boas Vindas ao ByteBank, Atendimento.");

//ArrayList _listaDeContas = new ArrayList();
List<ContaCorrente> _listaDeContas = new List<ContaCorrente>(){
  new ContaCorrente(100, "123456-G"),
  new ContaCorrente(101, "951258-H"),
  new ContaCorrente(102, "987321-I"),
  new ContaCorrente(96, "123456-A"),
  new ContaCorrente(95, "951258-B"),
  new ContaCorrente(96, "987321-C"),
  new ContaCorrente(97, "123456-D"),
  new ContaCorrente(98, "951258-E"),
  new ContaCorrente(99, "987321-F")
};

List<ContaCorrente> _listaDeContas2 = new List<ContaCorrente>(){
  new ContaCorrente(97, "123456-D"),
  new ContaCorrente(98, "951258-E"),
  new ContaCorrente(99, "987321-F")
};

List<ContaCorrente> _listaDeContas3 = new List<ContaCorrente>(){
  new ContaCorrente(100, "123456-G"),
  new ContaCorrente(101, "951258-H"),
  new ContaCorrente(102, "987321-I")
};

List<string> nomesDosEscolhidos = new List<string>()
{
    "Bruce Wayne",
    "Carlos Vilagran",
    "Richard Grayson",
    "Bob Kane",
    "Will Farrel",
    "Lois Lane",
    "General Welling",
    "Perla Letícia",
    "Uxas",
    "Diana Prince",
    "Elisabeth Romanova",
    "Anakin Wayne"
};


#region Exemplos Array en c#
/*
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

TestaArrayContasCorrentes();

void TestaArrayContasCorrentes()
{
    ListaDeContasCorrentes listaDeContas = new ListaDeContasCorrentes();
    listaDeContas.Adicionar(new ContaCorrente(874, "6565656-A"));
    listaDeContas.Adicionar(new ContaCorrente(874, "6455454-B"));
    listaDeContas.Adicionar(new ContaCorrente(874, "6454456-C"));

    Console.WriteLine(listaDeContas.MaiorSaldo().Saldo); 

}
*/
#endregion#


//bool verificaNomeList(List<string> lista, string nome)
//{
//    return lista.Contains(nome);
//}

//Console.WriteLine(verificaNomeList(nomesDosEscolhidos, "Bob Kane"));

AtendimentoCliente();
void AtendimentoCliente()
{
    char opcao = '0';
    try
    {
        while (opcao != '6')
        {
            Console.Clear();
            Console.WriteLine("===============================");
            Console.WriteLine("===       Atendimento       ===");
            Console.WriteLine("===1 - Cadastrar Conta      ===");
            Console.WriteLine("===2 - Listar Contas        ===");
            Console.WriteLine("===3 - Remover Conta        ===");
            Console.WriteLine("===4 - Ordenar Contas       ===");
            Console.WriteLine("===5 - Pesquisar Conta      ===");
            Console.WriteLine("===6 - Sair do Sistema      ===");
            Console.WriteLine("===============================");
            Console.WriteLine("\n\n");
            Console.Write("Digite a opção desejada: ");

            try
            {
                opcao = Console.ReadLine()[0];
            }
            catch (Exception e)
            {
                throw new ByteBankException(e.Message);
            }
            switch (opcao)
            {
                case '1':
                    CadastrarConta();
                    break;
                case '2':
                    ListarContas();
                    break;
                case '3':
                    RemoverConta();
                    break;
                case '4':
                    OrdenarConta();
                    break;
                case '5':
                    PesquisarContas();
                    break;
                case '6':

                    break;
                default:
                    Console.WriteLine("Opcao não implementada.");
                    break;
            }
        }
    }catch (ByteBankException e)
    {
        Console.WriteLine($"{e.Message}");
    }
}

void PesquisarContas()
{
    Console.Clear();
    Console.WriteLine("===============================");
    Console.WriteLine("===    PESQUISAR CONTAS     ===");
    Console.WriteLine("===============================");
    Console.WriteLine("\n");
    Console.Write("Deseja pesquisar por (1) NUMERO DA CONTA ou (2)CPF TITULAR ? ");
    switch (int.Parse(Console.ReadLine()))
    {
        case 1:
            {
                Console.Write("Informe o número da Conta: ");
                string _numeroConta = Console.ReadLine();
                ContaCorrente consultaConta = ConsultaPorNumeroConta(_numeroConta);
                Console.WriteLine(consultaConta.ToString());
                Console.ReadKey();
                break;
            }
        case 2:
            {
                Console.Write("Informe o CPF do Titular: ");
                string _cpf = Console.ReadLine();
                ContaCorrente consultaCpf = ConsultaPorCPFTitular(_cpf);
                Console.WriteLine(consultaCpf.ToString());
                Console.ReadKey();
                break;
            }
        default:
            Console.WriteLine("Opção não implementada.");
            break;
    }

}

ContaCorrente ConsultaPorCPFTitular(string? cpf)
{
    ContaCorrente conta = null;
    for (int i = 0; i < _listaDeContas.Count; i++)
    {
        if (_listaDeContas[i].Titular.Cpf.Equals(cpf))
        {
            conta = _listaDeContas[i];
        }
    }
    return conta;
}

ContaCorrente ConsultaPorNumeroConta(string? numeroConta)
{
    ContaCorrente conta = null;
    for (int i = 0; i < _listaDeContas.Count; i++)
    {
        if (_listaDeContas[i].Conta.Equals(numeroConta))
        {
            conta = _listaDeContas[i];
        }
    }

    return conta;
}


void OrdenarConta()
{
    foreach (var item in _listaDeContas)
    {
        Console.WriteLine(item.Numero_agencia);
    }
    Console.ReadKey();

    _listaDeContas.Sort();
    
    foreach (var item in _listaDeContas)
    {
        Console.WriteLine(item.Numero_agencia);
    }
}

void ListarContas()
{
    mostrarCabecalho("LISTA DE CONTAS");
    
    if (_listaDeContas.Count <= 0)
    {
        Console.WriteLine("... Não há contas cadastradas! ...");
        Console.ReadKey();
        return;
    }
    foreach (ContaCorrente item in _listaDeContas)
    {
        Console.WriteLine("===  Dados da Conta  ===");
        Console.WriteLine("Número da Conta : " + item.Conta);
        Console.WriteLine("Titular da Conta: " + item.Titular.Nome);
        Console.WriteLine("CPF do Titular  : " + item.Titular.Cpf);
        Console.WriteLine("Profissão do Titular: " + item.Titular.Profissao);
        Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
        Console.ReadKey();
    }
}


void RemoverConta(){
    mostrarCabecalho("CADASTRO CONTAS");

    ContaCorrente conta = null;
    Console.WriteLine("=== Informe dados da conta ===\n");
    Console.Write("Infome CPF do Titular: ");
    string cpf = Console.ReadLine();

    foreach (var item in _listaDeContas)
    {
        if (item.Conta.Equals(cpf)) conta = item;
    }
    
    if(conta != null)
    {
        conta.GravarOperacaoBrancaria("Finalizar Conta", "Saldo atual: " + conta.GetSaldo);
              

        _listaDeContas.Remove(conta);
        Console.WriteLine("Conta Removida com Sucesso");
    }
    else
    {
        Console.WriteLine("Conta Nao encontrada ");
    }

    
}

void CadastrarConta()
{
    mostrarCabecalho("CADASTRO CONTAS");
    
    Console.WriteLine("=== Informe dados da conta ===");
    try
    {
        Console.Write("Número da conta: ");
        string numeroConta = Console.ReadLine();

        Console.Write("Número da Agencia: ");
        int numeroAgencia = int.Parse(Console.ReadLine());

        ContaCorrente conta = new ContaCorrente(numeroAgencia, numeroConta);

        Console.Write("Infome nome do Titular: ");
        conta.Titular.Nome = Console.ReadLine();

        Console.Write("Infome CPF do Titular: ");
        conta.Titular.Cpf = Console.ReadLine();

        Console.Write("Infome Profissão do Titular: ");
        conta.Titular.Profissao = Console.ReadLine();

        _listaDeContas.Add(conta);

    }catch(ArgumentException e)
    {
        Console.WriteLine(e.Message);
        Console.ReadKey();
        return;
    }

    Console.WriteLine("... Conta cadastrada com sucesso! ...");
    Console.ReadKey();

}

void mostrarCabecalho(string titulo)
{
    Console.Clear();
    Console.WriteLine("===============================");
    Console.WriteLine("===     " + titulo + "     ===");
    Console.WriteLine("===============================");
    Console.WriteLine("\n");
}