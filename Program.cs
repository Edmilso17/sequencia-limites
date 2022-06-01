    
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("inicio: ");
        int inicio = Convert.ToInt32(Console.ReadLine());
        Console.ResetColor();

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("fim: ");
        int fim = Convert.ToInt32(Console.ReadLine());
        Console.ResetColor();

        if (fim >= inicio)

        {
            int n = inicio;

            while (n <= fim)
            {
                Console.Write($"{n} ");
                n += 1;
            }
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Não é possivel terminar antes de iniciar. ");
            Console.ResetColor();
        }
    }





