using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoHospedagem.Exceptions
{
    public class QuantidadeExcedidaException : Exception
    {
        public QuantidadeExcedidaException() : base("A capacidade disponível é menor que a quantidade requisitada")
        {

        }
    }
}
