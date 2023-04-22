
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static bytebank_ADM.SistemaInterno.SistemaInterno;

namespace bytebank_ADM.Sistema_Interno
{
    public class SistemaInterno
    {
        public bool Logar(IAutenticavel funcionario, string senha)
        {
            bool usuarioAutenticado = funcionario.Autenticar(senha);

            if (usuarioAutenticado)
            {
                Console.WriteLine("Usuario Autenticado com Sucesso");

                return true;
            }else {
                Console.WriteLine("Senha Incorreta!");
                return false; 
            }
        }

      

    }
}
