using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

// Cria os modelos de hóspedes e cadastra na lista de hóspedes
List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa(nome: "Amanda");
Pessoa p2 = new Pessoa(nome: "Luiza");
Pessoa p3 = new Pessoa(nome: "Raimundo");

hospedes.Add(p1);
hospedes.Add(p2);
hospedes.Add(p3);

// Cria a suíte
Suite suite = new Suite(tipoSuite: "Premium", capacidade: 10, valorDiaria: 65);

// Cria uma nova reserva, passando a suíte e os hóspedes

//Se os dias reservados forem maior ou igual a 10 sera aplicado um desconto de 10%
Reserva reserva = new Reserva(diasReservados: 10);

reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

// Exibe a quantidade de hóspedes e o valor da diária
Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");