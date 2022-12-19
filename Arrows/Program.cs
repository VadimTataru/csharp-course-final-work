StartApp();

void StartApp()
{
    ConsoleKey? key = null;
    while (true)
    {
        Console.Clear();
        Console.WriteLine("Вы можете указать направление указателя стрелочками!");
        Console.WriteLine("Нажмите [X] для выхода из программы");        

        switch(key)
        {
            case null: break;
            case ConsoleKey.X: return;
            case ConsoleKey.UpArrow:
                {
                    Console.WriteLine("↑");
                }
                break;
            case ConsoleKey.DownArrow:
                {
                    Console.WriteLine("↓");
                }
                break;
            case ConsoleKey.LeftArrow:
                {
                    Console.WriteLine("<-");
                }
                break;
            case ConsoleKey.RightArrow:
                {
                    Console.WriteLine("->");
                }
                break;
        }

        key = Console.ReadKey().Key;
    }
}