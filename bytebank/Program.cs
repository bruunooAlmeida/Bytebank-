using bytebank.Contas;
using bytebank.Titular;
using ByteBank;

LeitorDeArquivo leitor =new LeitorDeArquivo("contas.txt");
leitor.LerProximaLinha();
leitor.LerProximaLinha();
leitor.Fechar();

//try
//{   
//    ContaCorrente conta1 = new ContaCorrente(283, "1234-X");   
//    ContaCorrente conta2 = new ContaCorrente(284, "1234-Y");
//    ContaCorrente conta3 = new ContaCorrente(285, "1111-x");

//    conta1.Sacar(50);
//    conta2.Depositar(80);
//    //conta1.mostrarSaldoConta();
//    //conta1.Sacar(110);
//    conta1.MostrarExtratoBrancario();
//    //conta2.Sacar(100);

//    //    conta1.Depositar(2500);
//    conta1.Sacar(10000);
//    //Console.WriteLine(ContaCorrente.TaxaOperacao);
//}
//catch(ArgumentException e) 
//{
//    Console.WriteLine("Parametro com Erro " + e.ParamName);    
//    Console.WriteLine(e.Message);
//}
//catch (OperacaoFinanceiraException e)
//{
//    Console.WriteLine(e.Message);
//    Console.WriteLine(e.StackTrace);
//    Console.WriteLine("Operação não pode ser concluida. Saldo Insuficente");
//    Console.WriteLine(e.Message);
//}



//try
//{
//    ContaCorrente conta1 = new ContaCorrente(4564, "789684-x");
//    ContaCorrente conta2 = new ContaCorrente(7891, "456794-y");

//    // conta1.Transferir(10000, conta2);
//    conta1.Sacar(10000);
//}
//catch (OperacaoFinanceiraException e)
//{
//    Console.WriteLine(e.Message);
//    Console.WriteLine(e.StackTrace);

//    Console.WriteLine("Informações da INNER EXCEPTION (exceção interna):");

//    Console.WriteLine(e.InnerException.Message);
//    Console.WriteLine(e.InnerException.StackTrace);
//}

