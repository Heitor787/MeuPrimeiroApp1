

class program
{
    public static void Main()
    {
        int num;


        Console.WriteLine("Escreva um número: ");
        string info = Console.ReadLine();
        num = Convert.ToInt32(info);

        if (num % 2 == 0)
        {
            Console.WriteLine("O número é par!");
        }

        else
        {
            Console.WriteLine("O número e impar!");

        }

    }
}