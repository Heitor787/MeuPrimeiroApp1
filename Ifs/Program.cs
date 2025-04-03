class program
{
    public static void Main()
    {







        //if realiza operações que retorna verdadeiro ou falso
        //true - verdadeiro 
        //false - falso

        /* if (idade >= 18)*
         {
             Console.WriteLine("Você é maior de idade");

         }
         else if (idade <= 17)
         {    
        Console.WriteLine("Você é menor de idade");
         }*/





        /*  if (idade <= 14)
          {
              Console.WriteLine("Criança");

          }
          else if (idade <= 17)
          {
              Console.WriteLine("Adolescente");

          }

          else if (idade <= 30)
          {
              Console.WriteLine("Jovem Adulto");
          }

          else if (idade <= 59)
          {
              Console.WriteLine("Adulto");

          }

          else if (idade <= 59)
          {
              Console.WriteLine("Idoso");

          }

          else if (idade <= 150)
          {
              Console.WriteLine("Ancião");

          }

          else 
          {
              Console.WriteLine("pós-vida");

          } 
        */


        Console.WriteLine("Dia da semana : ");
        string dia = Console.ReadLine();

        switch (dia)
        {
            case "seg":
                Console.WriteLine("É segunda-feira");
                break;
            case "ter":
                Console.WriteLine("É terça-feira");
                break;
            case "qua":
                Console.WriteLine("É quarta-feira");
                break;
            case "qui":
                Console.WriteLine("É quinta-feira");
                break;
            case "sex":
                Console.WriteLine("É sexta-feira");
                break;
            case "sab":
                Console.WriteLine("É sabádo");
                break;
            case "dom":
                Console.WriteLine("É domingo");
                break;

            default:
                Console.WriteLine("bobão");
                break;

        }

    }
}
