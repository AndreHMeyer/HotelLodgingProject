using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoHospedagem.Exceptions
{
    public class OpcaoInvalidaException : Exception
    {
        public OpcaoInvalidaException(int escolha) : base("Opção " + escolha + " inválida! As opções são de 1 à 5.")
        {
        }
    }
}
