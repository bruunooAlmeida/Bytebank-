using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank.Contas
{
    public class opcoes
    {
        private static int idAutomatico;
        public int id { get; set; }
        public string observacao { get; set; }
        public string descricao { get; set; }       

        public opcoes() { }

        public opcoes(string descricao)
        {
            idAutomatico++;
            this .descricao = descricao;
            this.id = idAutomatico;
        }

    }
}
