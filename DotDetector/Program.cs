using DotDetector;

Circle circle = new Circle(0, -1, 2);

while (true)
{
    Console.Clear();
    Console.WriteLine("Введите координату [X]: ");
    int x;
    if (!int.TryParse(Console.ReadLine(), out x))
    {
        Console.WriteLine("Ввод не корректен");
        continue;
    }
    Console.WriteLine("Введите координату [Y]: ");
    int y;
    if (!int.TryParse(Console.ReadLine(), out y))
    {
        Console.WriteLine("Ввод не корректен");
        continue;
    }

    if(circle.IsPointBelong(x, y))
    {
        Console.WriteLine($"Точка ({x}, {y}) находится внутри окружности или лежит на ней!");
    } else
    {
        Console.WriteLine($"Точка ({x}, {y}) находится вне окружности!");
    }

    return;
}
