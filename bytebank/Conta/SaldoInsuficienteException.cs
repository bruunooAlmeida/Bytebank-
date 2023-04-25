using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank.Conta
{
    public class SaldoInsuficienteException : System.Exception
    {
        public SaldoInsuficienteException(string mensagem) : base(mensagem) { }
    }
}
