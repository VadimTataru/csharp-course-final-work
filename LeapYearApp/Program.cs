using LeapYearApp;

CheckYear();

void CheckYear()
{
    while (true)
    {
        Console.Clear();
        Console.WriteLine("Введите год в формате YYYY: ");
        int year;
        if (!int.TryParse(Console.ReadLine(), out year))
        {
            Console.WriteLine("Ввод не корректен");
            continue;
        }

        if (LeapYearService.IsLeap(year))
            Console.WriteLine($"Год {year} високосный!");
        else
            Console.WriteLine($"Год {year} не является високосным!");
        return;
    }

}