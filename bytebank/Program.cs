using bytebank.Contas;
using bytebank.Titular;


try
{
    
    ContaCorrente conta5 = new ContaCorrente(283, "1234-X");
    
    ContaCorrente conta6 = new ContaCorrente(284, "1234-Y");
    
    ContaCorrente conta7 = new ContaCorrente(285, "1111");

    Console.WriteLine(ContaCorrente.TaxaOperacao);
}
catch(ArgumentException e) 
{
    Console.WriteLine("Parametro com Erro " + e.ParamName);    
    Console.WriteLine(e.Message);
}



