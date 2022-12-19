DrawTable();

void DrawTable()
{
    for (int i = 0; i <= 10; i++)
    {
        for (int j = 0; j <= 10; j++)
        {
            if(i == 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                if (j == 0)
                    Console.Write($"     |");
                else if(j < 10)
                    Console.Write($"  {j}  |");
                else
                    Console.Write($"  {j} |");
            } else if (j == 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                if (i < 10)
                    Console.Write($"  {i}  |");
                else
                    Console.Write($"  {i} |");
            } else
            {
                Console.ResetColor();
                int result = i * j;
                if (result < 10)
                    Console.Write($"  {result}  |");
                else if (result < 100)
                    Console.Write($"  {result} |");
                else
                    Console.Write($" {result} |");
            }            
        }
        Console.WriteLine($"\n ________________________________________________________________ \n");
    }
}
