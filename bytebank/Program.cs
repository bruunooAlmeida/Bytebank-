using bytebank.Contas;
using bytebank.Titular;


try
{
    Console.WriteLine(ContaCorrente.TaxaOperacao);
    ContaCorrente conta5 = new ContaCorrente(0, "1234-X");
    Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

    ContaCorrente conta6 = new ContaCorrente(284, "9874-Z");
    Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

    ContaCorrente conta7 = new ContaCorrente(285, "1111-Z");
    Console.WriteLine(ContaCorrente.TotalDeContasCriadas);
}
catch(ArgumentException e) 
{
    Console.WriteLine( e.Message );
}



