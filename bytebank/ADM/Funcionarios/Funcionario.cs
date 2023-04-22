using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank.ADM.Funcionarios
{
    public abstract class Funcionario
    {
        public static int TotalFuncionarios { get; set; }
        public string Nome { get; set; }

        public string Cpf { get; private set; }

        public double Salario { get; set; }

        public string Senha { get; set; }

        public Funcionario(string nome, string cpf, double salario)
        {
            Nome = nome;
            Cpf = cpf;
            Salario = salario;

            TotalFuncionarios++;
        }

        public Funcionario(string cpf)
        {
            Cpf += cpf;
        }

        public Funcionario(string cpf, double salario)
        {
            Cpf += cpf;
            Salario = salario;
        }

        /// <summary>
        /// Este método retorna 10% do salario do Funcionario

        /// </summary>
        /// <returns>this.salario.</returns>
        public abstract double GetBonificacao();

        public abstract void AumentarSalario();

        public virtual void MostrarInformacao()
        {
            Console.WriteLine("Nome...:" + Nome + '\n' +
                              "CPF....:" + Cpf + '\n' +
                              "Salario:" + Salario);
        }
    }
}
