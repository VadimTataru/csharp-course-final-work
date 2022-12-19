CheckYear();

void CheckYear()
{
    while (true)
    {
        Console.WriteLine("Введите год в формате YYYY: ");
        int year;
        if (!int.TryParse(Console.ReadLine(), out year))
        {
            Console.WriteLine("Ввод не корректен");
            continue;
        }

        if (IsLeap(year))
            Console.WriteLine($"Год {year} високосный!");
        else
            Console.WriteLine($"Год {year} не является високосным!");
        return;
    }

}


bool IsLeap(int year)
{
    if(year % 4 == 0)
        return true;
    else
        return false;
}