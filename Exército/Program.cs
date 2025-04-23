class Program
{
    public static void Main()
    {
        int idade;
        float altura;

        Console.WriteLine("Informe a sua idade");
        idade = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Informe a sua altura");
        altura = float.Parse(Console.ReadLine());

        if (altura >= 1.65 && idade >= 18)
        {
            Console.WriteLine("Você pode se alistar");
        }
        else
        {
            Console.Write("Você não pode se alistar");
        }
        
    }
}