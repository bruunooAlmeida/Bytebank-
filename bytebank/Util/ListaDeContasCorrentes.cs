using bytebank.Contas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank.Util
{

    public class ListaDeContasCorrentes
    {
        private int _proximaPosicao = 0;
        private ContaCorrente[] _itens = null;
        public ListaDeContasCorrentes(int tamanhoInicial = 5) 
        {
            _itens = new ContaCorrente[tamanhoInicial];
        } 

        public void Adicionar(ContaCorrente item)
        {
            Console.WriteLine("Adicionando Elementos");
            _itens[_proximaPosicao] = item;
            _proximaPosicao++;
        }

        public void Remover(ContaCorrente item)
        {
            Console.WriteLine("Adicionando Elementos");
            foreach (var itens in _itens)
            {
                if (itens.Equals(item)){
                    _itens = null;
                    _proximaPosicao--; 
                }
            }
            _itens[_proximaPosicao] = item;
            _proximaPosicao++;
        }

        public void ExibeLista()
        {
            for (int i = 0; i < _itens.Length; i++)
            {
                if (_itens[i] != null)
                {
                    var conta = _itens[i];
                    Console.WriteLine($" Indice[{i}] = Conta:{conta.Conta} - N° da Agência: {conta.Numero_agencia}");
                }
            }
        }


        public ContaCorrente MaiorSaldo()
        {

            ContaCorrente conta = null;
            double maiorValor = 0;
            for (int i = 0; i < _itens.Length; i++)
            {
                if (_itens[i] != null)
                {
                    if (maiorValor < _itens[i].Saldo)
                    {
                        maiorValor = _itens[i].Saldo;
                        conta = _itens[i];
                    }
                }

            }

            return conta;
        }


    }
}
