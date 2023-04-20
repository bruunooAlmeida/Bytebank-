using bytebank.Titular;
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
        private int numero_agencia;
        
        private List<ExtratoBrancario> extrato = new List<ExtratoBrancario>();

        public int Numero_agencia
        {
            get { return this.numero_agencia; }
            private set {
                    if (value > 0)
                    {
                        this.numero_agencia = value;
                    }
                }
        }

       
        public string Conta { get; set; }

        private double saldo = 100;

        public Cliente Titular { get; set; }

        public void Depositar(double valor)
        {
            saldo += valor;
            GravarOperacaoBrancaria("Depositou", (valor.ToString() + "\n" + "Saldo Atual: " + this.saldo));
        }

        public bool Sacar(double valor)
        {
            
            if (valor <= saldo)
            {
                saldo -= valor;
                GravarOperacaoBrancaria("Retirada", ("Retirada de " + valor + " para Conta:" + this.Conta) + "\n" + "Saldo atual: " + saldo);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Transferir(double valor, ContaCorrente destino)
        {
            if (saldo < valor)
            {
                return false;
            }
            else
            {

                Sacar(valor);        
                
                destino.Depositar(valor);
                
                
                return true;
            }
        }

        public void SetSaldo(double valor)
        {
            if(valor < 0)
            {
                return;
            }
            else
            {
                this.saldo = valor;
            }
        }

        public double GetSaldo()
        {
            return this.saldo;
        }

        public ContaCorrente(int numero_agencia, string numero_conta)
        {
            this.Numero_agencia = numero_agencia;
            this.Conta = numero_conta;
            if(numero_agencia <= 0)
            {
                throw new ArgumentException("Numero da conta nao pode ser 0", nameof(numero_agencia));
            }

            if(numero_conta == null)
            {
                throw new ArgumentException("Codigo da agencia nao pode ser vazio", nameof(numero_conta));
            }

            if (! numero_conta.Contains('-'))
            {
                throw new ArgumentException("Agencia nao possui codigo indentificado", nameof(numero_conta));
            }

            GravarOperacaoBrancaria("Iniciou a Conta", ("Saldo Atual: " + this.saldo));

            //try
            //{
            //    TaxaOperacao = 30 / TotalDeContasCriadas;

            //}
            //catch (DivideByZeroException) 
            //{
            //    Console.WriteLine("Ocorreu um erro! não é permitido uma divisão por Zero");
            //}
            //finally { }


            TotalDeContasCriadas++;
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