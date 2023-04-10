using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoHospedagem
{
    public class Reserva
    {
        public Suite Suite { get; set; }
        public List<Pessoa> Hospedes { get; set; }
        public int DiasReservados { get; set; }

        public Reserva ()
        {
            Hospedes = new List<Pessoa>();
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public void CadastrarHospedes(Pessoa hospede)
        {
            if (hospede == null)
            {
                throw new ArgumentNullException(nameof(hospede));
            }

            if (Suite == null)
            {
                throw new Exceptions.SuiteNaoCadastradaException();
            }

            if (Hospedes.Count >= Suite.Capacidade)
            {
                throw new Exceptions.QuantidadeExcedidaException();
            }

            Hospedes.Add(hospede);
        }

        public int ObterQuantidadeHospedes()
        {
            return Hospedes.Count;
        }

        public decimal CalcularValorTotal(int diasReservados)
        {
            if (diasReservados <= 0)
            {
                throw new ArgumentException("O número de dias reservados deve ser maior que zero.");
            }

            this.DiasReservados = diasReservados;

            if (this.DiasReservados > 10)
            {
                return (Suite.ValorDiaria * 0.9m) * DiasReservados;
            }
            else
            {
                return Suite.ValorDiaria * DiasReservados;
            }
        }
    }
}
