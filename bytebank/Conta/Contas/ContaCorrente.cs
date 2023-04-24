using bytebank.Conta;
using bytebank.Conta.Titular;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank.Contas
{
    public class ContaCorrente
    {
        public static int TotalDeContasCriadas { get; private set; }
        public static int TaxaOperacao;
        
        
        private List<ExtratoBrancario> extrato = new List<ExtratoBrancario>();
        
        public int Numero_agencia{ get; set; }
       
        public string Conta { get; set; }

        public double Saldo { get; set; }

        public Cliente Titular { get; set; }

        public int ContadorSaquesNaoPermitidos { get; set; }
        
        public int ContadorTransferenciasNaoPermitidas { get; private set; }

        public ContaCorrente(int numero_agencia, string numero_conta)
        {
            this.Numero_agencia = numero_agencia;
            this.Conta = numero_conta;
            this.Saldo = 100;
            if (numero_agencia <= 0)
            {
                throw new ArgumentException("Numero da conta nao pode ser 0", nameof(numero_agencia));
            }

            if (numero_conta == null)
            {
                throw new ArgumentException("Codigo da agencia nao pode ser vazio", nameof(numero_conta));
            }

            if (!numero_conta.Contains('-'))
            {
                throw new ArgumentException("Agencia nao possui codigo indentificado", nameof(numero_conta));
            }

            GravarOperacaoBrancaria("Iniciou a Conta", ("Saldo Atual: " + this.Saldo));

            TotalDeContasCriadas++;
        }


        public void Depositar(double valor)
        {
            this.Saldo += valor;
            GravarOperacaoBrancaria("Depositou", (valor.ToString() + "\n" + "Saldo Atual: " + this.Saldo));
        }

        public bool Sacar(double valor)
        {
            
            if (valor <= this.Saldo)
            {
                this.Saldo -= valor;
                GravarOperacaoBrancaria("Retirada", ("Retirada de " + valor + " para Conta:" + this.Conta) + "\n" + "Saldo atual: " + this.Saldo);
                return true;
            }
            else
            {
                ContadorSaquesNaoPermitidos++;
                throw new SaldoInsuficienteException("Saldo insuficiente para Operação");
            }
        }

        public bool Transferir(double valor, ContaCorrente destino)
        {
            try
            {

                Sacar(valor);
                ContadorTransferenciasNaoPermitidas++;
            }catch(SaldoInsuficienteException e)
            {
                throw new OperacaoFinanceiraException("Operação não realizada.", e);
            }                
             destino.Depositar(valor);
               return true;
            
        }

        private void SetSaldo(double valor)
        {
            if(valor < 0)
            {
                return;
            }
            else
            {
                this.Saldo = valor;
            }
        }

        public double GetSaldo()
        {
            return this.Saldo;
        }
       
        public void mostrarSaldoConta()
        {
            Console.WriteLine(GetSaldo());
        }

        public void GravarOperacaoBrancaria(string operacao,string observacao)
        {
            DateTime currentDateTime = DateTime.Now;
            var OperacaoBrancaria = new ExtratoBrancario(currentDateTime, operacao, observacao);
            
            extrato.Add(OperacaoBrancaria);
        }

        public void MostrarExtratoBrancario()
        {
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("----------------Extato Brancario-----------------");
            foreach (ExtratoBrancario extrato in extrato)
            {
                Console.WriteLine("-------------------------------------------------\n");
                Console.WriteLine("Operacao..: " + extrato.descricao     + '\n');                
                Console.WriteLine("Data......: " + extrato.DataMotivacao + '\n');                
                Console.WriteLine("Observação: " + extrato.observacao    + '\n');
                
            }

            Console.WriteLine("---------------------------------------------");
        }
    }
}