using ProjetoHospedagem.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoHospedagem
{
    public class ReservaGUI
    {
        Reserva reserva;

        public ReservaGUI(Reserva reserva)
        {
            this.reserva = reserva;
        }

        public void Menu()
        {
            int escolha;
            do
            {

                Console.Clear();

                Console.WriteLine("--- MENU ---");
                Console.WriteLine("1 - Cadastrar Suíte");
                Console.WriteLine("2 - Cadastrar Hóspedes");
                Console.WriteLine("3 - Obter quantidade de hóspedes");
                Console.WriteLine("4 - Valor total");
                Console.WriteLine("5 - Sair");
                Console.Write("Opção: ");
                escolha = int.Parse(Console.ReadLine());

                switch(escolha)
                {
                    case 1: this.CadastrarSuite(); break;
                    case 2: this.CadastrarHospedes(); break;
                    case 3: this.ObterQuantidadeHospedes(); break;
                    case 4: this.CalcularValorTotal(); break;
                    case 5: Console.Clear();  Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("Saindo..."); break;
                    default: throw new Exceptions.OpcaoInvalidaException(escolha);
                }

            } while (escolha != 5);
        }

        private void CadastrarSuite()
        {
            Console.Clear();

            Console.Write("Digite o tipo da suíte: ");
            string tipo = Console.ReadLine();
            Console.Write("Digite a capacidade da suíte: ");
            int capacidade = int.Parse(Console.ReadLine());
            Console.Write("Digite o valor da diária da suíte: ");
            decimal valorDiaria = decimal.Parse(Console.ReadLine());

            this.reserva.CadastrarSuite(new Suite(tipo, capacidade, valorDiaria));
        }

        private void CadastrarHospedes()
        {
            Console.Clear();

            Console.Write("Digite o nome: ");
            string nome = Console.ReadLine();
            Console.Write("Digite o sobrenome: ");
            string sobrenome = Console.ReadLine();

            this.reserva.CadastrarHospedes(new Pessoa(nome, sobrenome));
        }

        private void ObterQuantidadeHospedes()
        {
            Console.Clear();

            Console.WriteLine("Quantidade de hóspedes: " + this.reserva.ObterQuantidadeHospedes() + "\n");
            for (int i = 1; i <= this.reserva.ObterQuantidadeHospedes(); i++)
            {
                Console.WriteLine(i + " - " + this.reserva.Hospedes[i - 1].Nome + " " + this.reserva.Hospedes[i - 1].Sobrenome);
            }

            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();

        }

        private void CalcularValorTotal()
        {
            Console.Clear();

            Console.Write("Digite a quantidade de dias da hospedagem: ");
            int quantidadeDias = int.Parse(Console.ReadLine());

            Console.WriteLine("O valor total é: R$ " + reserva.CalcularValorTotal(quantidadeDias));

            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
    }
}
