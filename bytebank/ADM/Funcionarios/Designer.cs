using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank.ADM.Funcionarios
{
    public class Designer : Funcionario

    {
        public Designer(string cpf) : base(cpf) { }

        public override double GetBonificacao()
        {
            return Salario * 0.17;
        }

        public override void AumentarSalario()
        {
            Salario *= 0.11;
        }
    }
}
