using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank.ADM.Funcionarios
{
    public class Auxiliar : Funcionario
    {
        public Auxiliar(string cpf) : base(cpf) { }

        public override double GetBonificacao()
        {
            return Salario * 0.15;
        }

        public override void AumentarSalario()
        {
            Salario *= 0.15;
        }
    }
}
