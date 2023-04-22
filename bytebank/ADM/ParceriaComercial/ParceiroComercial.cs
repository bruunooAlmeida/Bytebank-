using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static bytebank_ADM.SistemaInterno.SistemaInterno;

namespace bytebank.ADM.ParceriaComercial
{
    public class ParceiroComercial : IAutenticavel
    {
        public string Senha { get; set; }

        public ParceiroComercial(string senha) { }

        public bool Autenticar(string senha)
        {
            return Senha == senha;
        }
    }
}
