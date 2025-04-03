class Program
{
    public static void Main()
    {
        Console.WriteLine("Qual a sua idade?");
        int idade = Convert.ToInt32(Console.ReadLine());

        if (idade >= 18)
            Console.WriteLine("Você é maior de idade.");
        else
            Console.WriteLine("Você é menor de idade.");
    }
}