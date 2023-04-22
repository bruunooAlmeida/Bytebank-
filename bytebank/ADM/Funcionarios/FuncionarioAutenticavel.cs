using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static bytebank_ADM.SistemaInterno.SistemaInterno;

namespace bytebank.ADM.Funcionarios
{
    public abstract class FuncionarioAutenticavel : Funcionario, IAutenticavel
    {
        public FuncionarioAutenticavel(string cpf) : base(cpf)
        {
        }

        protected FuncionarioAutenticavel(string cpf, double salario) : base(cpf, salario) { }

        protected FuncionarioAutenticavel(string nome, string cpf, double salario) : base(nome, cpf, salario) { }

        public string Senha { get; set; }
        public bool Autenticar(string senha)
        {
            return Senha == senha;
        }
    }
}
