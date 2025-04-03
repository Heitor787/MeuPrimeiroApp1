//Receber o ano de nascimento da pessoa 
//Receber o ano atual 
//Calcular a idade da pessoa
//Mostrar a idade da pessoa na tela

class Program
{
    public static void Main()
    {
        int ano1, ano2;

        Console.WriteLine("Entre com o seu ano de nascimento: ");

        string informacao = Console.ReadLine();

        ano1 = Convert.ToInt32(informacao);

        Console.WriteLine("Entre com o ano atual: ");

        string informacao2 = Console.ReadLine();

        ano2 = Convert.ToInt32(informacao2);

        int subtracao = ano2 - ano1;

        Console.WriteLine("Sua idade é: {0}", subtracao);
    }
}