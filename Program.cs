using System;

class Program
{
  static void Main(string[] args)
  {
    while (true)
    {
      ExibirMenu();
      string opcao = Console.ReadLine();

      switch (opcao)
      {
        case "1":
          OperacoesBasicas();
          break;
        case "2":
          OperacoesAvancadas();
          break;
        case "0":
          Console.WriteLine("Saindo... Até logo!");
          return;
        default:
          Console.WriteLine("Opção inválida. Tente novamente.");
          break;
      }
    }
  }

  static void ExibirMenu()
  {
    Console.WriteLine("\nCalculadora Avançada");
    Console.WriteLine("1. Operações Básicas (Soma, Subtração, etc.)");
    Console.WriteLine("2. Funções Avançadas (Exponenciação, Raiz Quadrada, etc.)");
    Console.WriteLine("0. Sair");
    Console.Write("Escolha uma opção: ");
  }

  static void OperacoesBasicas()
  {
    Console.Write("Digite o primeiro número: ");
    double num1 = double.Parse(Console.ReadLine());

    Console.Write("Digite o operador (+, -, *, /): ");
    string operador = Console.ReadLine();

    Console.Write("Digite o segundo número: ");
    double num2 = double.Parse(Console.ReadLine());

    double resultado;

    if (operador == "+")
    {
      resultado = num1 + num2;
    }
    else if (operador == "-")
    {
      resultado = num1 - num2;
    }
    else if (operador == "*")
    {
      resultado = num1 * num2;
    }
    else if (operador == "/")
    {
      if (num2 != 0)
        resultado = num1 / num2;
      else
        resultado = double.NaN; // Ou trate a divisão por zero de outra maneira
    }
    else
    {
      resultado = double.NaN; // Caso o operador seja inválido
    }

    Console.WriteLine($"Resultado: {resultado}");
  }

  static void OperacoesAvancadas()
  {
    Console.WriteLine("Escolha uma operação:");
    Console.WriteLine("1. Exponenciação");
    Console.WriteLine("2. Raiz Quadrada");
    Console.WriteLine("3. Seno e Cosseno");
    string escolha = Console.ReadLine();

    switch (escolha)
    {
      case "1":
        Console.Write("Digite a base: ");
        double baseNum = double.Parse(Console.ReadLine());
        Console.Write("Digite o expoente: ");
        double expoente = double.Parse(Console.ReadLine());
        Console.WriteLine($"Resultado: {Math.Pow(baseNum, expoente)}");
        break;

      case "2":
        Console.Write("Digite o número: ");
        double numero = double.Parse(Console.ReadLine());
        Console.WriteLine($"Resultado: {Math.Sqrt(numero)}");
        break;

      case "3":
        Console.Write("Digite o ângulo em graus: ");
        double angulo = double.Parse(Console.ReadLine());
        double radianos = angulo * Math.PI / 180;
        Console.WriteLine($"Seno: {Math.Sin(radianos)}, Cosseno: {Math.Cos(radianos)}");
        break;

      default:
        Console.WriteLine("Opção inválida.");
        break;
    }
  }
}
