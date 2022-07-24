
// table of multiplication
repeat();
void repeat()
{
    try
    {
        Console.WriteLine("\n¿Hasta que número quieres ver las tablas de Multiplicar? ");
        int n = Convert.ToInt32(Console.ReadLine());
        bool y = true;
        multi(n, y);
    }
    catch
    {
        Console.WriteLine("Solo debes escribir numeros ");
        
    }
}

void multi(int n, bool y)
{
    while (y == true)
    {
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine($"\nTabla de multiplicar del {i}");
            for (int j = 1; j <= 12; j++)
            {
                Console.WriteLine($"{i} x {j} = {i * j}");
            }
        }
        Console.WriteLine($"Ok, aquí arriba tienes las tablas del 1 hasta {n}");
      
        Console.WriteLine("¿Quieres jugar de nuevo? y/n default (y)");
        string choice = Console.ReadLine();
        if (choice != "n")
        {
            repeat();
        }
        else
        {
            Environment.Exit(0);
        }
    }
}





