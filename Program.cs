using ProjetoCalculadora.Calculadora;

Console.WriteLine("Bem vindo, você está utilizando a calculadora 2.0");
Console.WriteLine(DateTime.Now);

Calcular();

void Calcular()
{
    Console.WriteLine("(1)Soma | (2)Subtração | (3)Multiplicação" + Environment.NewLine +
                       "(4)Divisão | (5)Exponenciação | (6)Seno" + Environment.NewLine +
                       "(7)Coseno | (8)Tangente | (9)Raiz Quadrada" + Environment.NewLine +
                       "(10)Sair");


    string calculo = "0";

    Calculator calc = new Calculator();
    while (calculo != "10")
    {
        Console.WriteLine("Digite uma função: ");
        calculo = Console.ReadLine();

        switch (calculo)
        {
            
            case "1":
                Console.WriteLine("Função: Soma");
                Console.WriteLine("Insira o primeiro número: ");
                double n1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Insira o segundo número: ");
                double n2 = Convert.ToDouble(Console.ReadLine());
                calc.Somar(n1, n2);
                break;

            case "2":
                Console.WriteLine("Função: Subtração");
                Console.WriteLine("Insira o primeiro número: ");
                n1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Insira o segundo número: ");
                n2 = Convert.ToDouble(Console.ReadLine());
                calc.Subtrair(n1, n2);
                break;

            case "3":
                Console.WriteLine("Função: Multiplicação");
                Console.WriteLine("Insira o primeiro número: ");
                n1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Insira o segundo número: ");
                n2 = Convert.ToDouble(Console.ReadLine());
                calc.Multiplicar(n1, n2);
                break;

            case "4":
                Console.WriteLine("Função: Divisão");
                Console.WriteLine("Insira o primeiro número: ");
                n1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Insira o segundo número: ");
                n2 = Convert.ToDouble(Console.ReadLine());
                calc.Dividir(n1, n2);
                break;

            case "5":
                Console.WriteLine("Função: Exponenciação");
                Console.WriteLine("Insira o primeiro número: ");
                n1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Insira o segundo número: ");
                n2 = Convert.ToDouble(Console.ReadLine());
                calc.Potencia(n1, n2);
                break;

            case "6":
                Console.WriteLine("Função: Seno");
                Console.WriteLine("Insira o valor do ângulo: ");
                n1 = Convert.ToDouble(Console.ReadLine());
                calc.Seno(n1);
                break;

            case "7":
                Console.WriteLine("Função: Coseno");
                Console.WriteLine("Insira o valor do ângulo: ");
                n1 = Convert.ToDouble(Console.ReadLine());
                calc.Coseno(n1);
                break;

            case "8":
                Console.WriteLine("Função: Tangente");
                Console.WriteLine("Insira o valor do ângulo: ");
                n1 = Convert.ToDouble(Console.ReadLine());
                calc.Tangente(n1);
                break;

            case "9":
                Console.WriteLine("Função: Raiz Quadrada");
                Console.WriteLine("Insira um valor para calcular a raiz: ");
                n1 = Convert.ToDouble(Console.ReadLine());
                calc.RaizQuadrada(n1);
                break;

            case "10":
                Console.WriteLine("Você selecionou sair...");
                break;

            default:
                Console.WriteLine("Escolha uma opção válida!!!");
                break;
        }
    }
}