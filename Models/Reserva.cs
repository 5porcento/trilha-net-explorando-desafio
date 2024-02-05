namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            //  IMPLEMENTADO
            if (hospedes.Count <= Suite.Capacidade)
            {
                Hospedes = hospedes;
            }
            else
            {
                //  IMPLEMENTADO
                throw new Exception ("Capacidade da Suite Insuficiente");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            //  IMPLEMENTADO
             int quantidadeHospedes = Hospedes.Count;
           // Console.WriteLine();
            return quantidadeHospedes;
        }

        public decimal CalcularValorDiaria()
        {
            // IMPLEMENTADO
            decimal valor = 0;
            valor = DiasReservados*Suite.ValorDiaria;

            //  IMPLEMENTADO
            if (DiasReservados >=10)
            {
                valor = valor - (valor* 0.10m);
            }

            return valor;
        }
    }
}