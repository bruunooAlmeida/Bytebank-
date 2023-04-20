using bytebank.Auxiliar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank.Contas
{
    public class ExtratoBrancario
    {
        public DateTime DataMotivacao { get; set; }
      
        public string descricao { get; set; }
        public string observacao { get; set; }
        
        public ExtratoBrancario()
        {

        }

        public ExtratoBrancario(DateTime data, string descricao, string obs)
        {
            this.DataMotivacao = data;
            this.descricao     = descricao;
            this.observacao    = obs;
        }
        

    }
}
