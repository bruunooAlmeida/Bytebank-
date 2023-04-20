using bytebank.Auxiliar;
using bytebank.Contas;
using bytebank.Titular;



try
{
    
    ContaCorrente conta1 = new ContaCorrente(283, "1234-X");
    
    ContaCorrente conta2 = new ContaCorrente(284, "1234-Y");
    
    ContaCorrente conta3 = new ContaCorrente(285, "1111-x");

    conta1.Sacar(50);
    conta2.Sacar(100);

    conta1.Depositar(2500);

    conta1.MostrarExtratoBrancario();

    //Console.WriteLine(ContaCorrente.TaxaOperacao);
}
catch(ArgumentException e) 
{
    Console.WriteLine("Parametro com Erro " + e.ParamName);    
    Console.WriteLine(e.Message);
}



