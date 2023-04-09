namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }
        private decimal valor;
        private decimal desconto = 10;

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> _Hospedes)
        {
            // TODO: Verificar se a capacidade é maior ou igual ao número de hóspedes sendo recebido
            if(_Hospedes.Count <= Suite.Capacidade)
            {
                Hospedes = _Hospedes;
            }
            else
            {
                // TODO: Retornar uma exception caso a capacidade seja menor que o número de hóspedes recebido
                Console.WriteLine("A capacidade de hospedes foi excedida");
            }
        }

        public void CadastrarSuite(Suite _Suite)
        {
            Suite = _Suite;
        }

        public int ObterQuantidadeHospedes()
        {
            // TODO: Retorna a quantidade de hóspedes (propriedade Hospedes)
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            // TODO: Retorna o valor da diária

            // Cálculo: DiasReservados X Suite.ValorDiaria

            valor = DiasReservados * Suite.ValorDiaria;

            Console.WriteLine("Valor total da diaria : " + valor);

            // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
            if (DiasReservados >= 10)
            {
                desconto = desconto * valor / 100;
                valor -= desconto;
            }

            Console.WriteLine("Um desconto de " + desconto + " reais (10%) foi aplicado sobre o valor total");

            return valor;
        }
    }
}