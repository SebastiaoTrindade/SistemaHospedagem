
using SistemaHospedagem.Models;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;

// Cria modelos de hóspede e cadastra
List<Pessoa> hospede = new List<Pessoa>();

Pessoa pessoa1 = new Pessoa("Hóspede 1");
Pessoa pessoa2 = new Pessoa("Hóspede 2");

hospede.Add(pessoa1);
hospede.Add(pessoa2);

// Insere uma suíte
Suite suite = new Suite(tipoSuite: "Premium", capacidade: 2, valorDiaria: 50);

// Cria uma nova reserva
Reserva reserva = new Reserva(diasReservados: 10);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospede);

// Exibe reserva completa
Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");
