class Program
{
    public static void Main()
    {
        // digite dois números
        Console.WriteLine("Digite o primeiro número: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite o segundo número: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        // Exiba o menu de opções
        Console.WriteLine("Escolha a operação:");
        Console.WriteLine("1 - Soma");
        Console.WriteLine("2 - Subtração");
        Console.WriteLine("3 - Multiplicação");
        Console.WriteLine("4 - Divisão");

        // Ler o que o usuário escolheu
        int escolha = Convert.ToInt32(Console.ReadLine());

        // Realizar a operação com switch
        switch (escolha)
        {
            case 1:
                Console.WriteLine("Resultado: " + (num1 + num2));
                break;
            case 2:
                Console.WriteLine("Resultado: " + (num1 - num2));
                break;
            case 3:
                Console.WriteLine("Resultado: " + (num1 * num2));
                break;
            case 4:
                if (num2 != 0)
                    Console.WriteLine("Resultado: " + (num1 / num2));
                else
                    Console.WriteLine("Erro: Não é possível dividir por zero.");
                break;
            default:
                Console.WriteLine("Opção inválida. Tente novamente.");
                break;
        }
    }
}