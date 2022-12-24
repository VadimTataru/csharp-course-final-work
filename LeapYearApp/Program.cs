﻿CheckYear();

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

        if (IsLeap(year))
            Console.WriteLine($"Год {year} високосный!");
        else
            Console.WriteLine($"Год {year} не является високосным!");
        return;
    }

}

/// <summary>
/// Метод определяет, является ли год високосным.
/// <returns>Год високосный? - true, иначе - false</returns>
/// </summary>
bool IsLeap(int year)
{
    if((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
        return true;
    else
        return false;
}