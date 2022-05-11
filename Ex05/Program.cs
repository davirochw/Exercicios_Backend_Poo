using Ex05.src;

Carro carro;
Motor motor;

Console.WriteLine("Digite a Placa do carro:");
string placa = Console.ReadLine();

Console.WriteLine("Digite o Modelo do carro:");
string modelo = Console.ReadLine();

Console.WriteLine("Digite a Cilindrada do motor:");
double cilindrada = double.Parse(Console.ReadLine());

motor = new Motor(cilindrada);

carro = new Carro(placa, modelo, motor);

motor.VelocidadeMaxima(carro);
