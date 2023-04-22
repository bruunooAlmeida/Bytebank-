using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bytebank_ADM.Sistema_Interno;
using static bytebank_ADM.SistemaInterno.SistemaInterno;

namespace bytebank.ADM.Funcionarios
{
    public class Diretor : FuncionarioAutenticavel
    {

        public int nivel { get; set; }

        public Diretor(int nivel, string nome, string cpf) : base(nome, cpf, 5000)
        {
            this.nivel = nivel;
        }

        public Diretor(string cpf) : base(cpf)
        {

        }
        /// <summary>
        /// Este método retorna 10% do salario do Funcionario

        /// </summary>
        /// <returns>this.salario.</returns>
        public override double GetBonificacao()
        {
            return Salario * 0.15;
        }

        public override void AumentarSalario()
        {
            Salario *= 0.15;
        }

        public override void MostrarInformacao()
        {
            Console.WriteLine(".........Diretor........\n" +
                              "Nome...:" + Nome + '\n' +
                              "CPF....:" + Cpf + '\n' +
                              "Salario:" + Salario);
        }


    }
}
