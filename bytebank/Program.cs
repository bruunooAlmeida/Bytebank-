using bytebank.Auxiliar;
using bytebank.Contas;
using bytebank.Titular;



try
{
    
    ContaCorrente conta1 = new ContaCorrente(283, "1234-X");
    
    ContaCorrente conta2 = new ContaCorrente(284, "1234-Y");
    
    ContaCorrente conta3 = new ContaCorrente(285, "1111");

    conta1.Sacar(50);
    

    Console.WriteLine(ContaCorrente.TaxaOperacao);
}
catch(ArgumentException e) 
{
    Console.WriteLine("Parametro com Erro " + e.ParamName);    
    Console.WriteLine(e.Message);
}



