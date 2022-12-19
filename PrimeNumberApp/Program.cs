CheckNumber();

void CheckNumber()
{
    while (true)
    {
        Console.Clear();
        Console.WriteLine("Введите число для проверки: ");
        int number;
        if (!int.TryParse(Console.ReadLine(), out number))
        {
            Console.WriteLine("Ввод не корректен");
            continue;
        }

        if (IsNumberPrime(number))
            Console.WriteLine($"Число {number} простое!");
        else
            Console.WriteLine($"Число {number} не является простым!");
        return;
    }
    
}


bool IsNumberPrime(int number)
{
    if (number <= 1) return false;

    int bound = (int)number / 2;
    for(int i = 2; i < bound; i++)
        if(number % i == 0)
            return false;

    return true;
}