using bytebank.ADM.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank.ADM.Utilitario
{
    public class GerenciadorDeBonificacao
    {
        public double TotalDeBonficacao { get; private set; }

        public void Registrar(Funcionario funcionario)
        {
            TotalDeBonficacao += funcionario.GetBonificacao();
        }

        public void Registrar(Diretor diretor)
        {
            TotalDeBonficacao += diretor.GetBonificacao();
        }

        public void MostrarTotal()
        {
            Console.WriteLine("Total: " + TotalDeBonficacao);
        }
    }
}
