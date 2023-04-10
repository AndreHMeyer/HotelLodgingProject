using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoHospedagem.Exceptions
{
    public class SuiteNaoCadastradaException : Exception
    {
        public SuiteNaoCadastradaException() : base("Ainda não existe uma suite cadastrada no sistema.")
        {

        }
    }
}
