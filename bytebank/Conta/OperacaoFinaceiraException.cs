using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank.Conta
{
    public class OperacaoFinanceiraException :  System.Exception
    {

        public OperacaoFinanceiraException() { }

        public OperacaoFinanceiraException(string mensagem) : base(mensagem) { }

        public OperacaoFinanceiraException(string mensagem, System.Exception excecaoInterna) : base(mensagem, excecaoInterna) { }
    }


}
