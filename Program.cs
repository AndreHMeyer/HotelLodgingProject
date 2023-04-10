namespace ProjetoHospedagem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Reserva reserva = new Reserva();
            ReservaGUI gui = new ReservaGUI(reserva);
            gui.Menu();
        }
    }
}