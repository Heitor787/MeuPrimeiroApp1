class Program
{
    public static void Main()
    {
        Console.WriteLine("Digite a nota do aluno: ");
        double nota = Convert.ToDouble(Console.ReadLine());

        if (nota >= 9)
            Console.WriteLine("Conceito: A");
        else if (nota >= 7)
            Console.WriteLine("Conceito: B");
        else if (nota >= 5)
            Console.WriteLine("Conceito: C");
        else
            Console.WriteLine("Conceito: D");
    }
}