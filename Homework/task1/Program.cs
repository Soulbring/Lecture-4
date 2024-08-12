//Напишите программу, которая бесконечно запрашивает целые числа с консоли.
//Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.


int DoNumberSumm (int Number)
{
    int sum = 0;
    int digit = 0;
    while(Number > 0)
    {
        digit = Number % 10;
        sum = sum + digit;
        Number = Number / 10;
    }
    return sum;
}

while (true)
{
    Console.WriteLine("Введите целое число:");
    string NumberString = Console.ReadLine();
    if (NumberString == "q")
    {
        Console.WriteLine("Вы ввели q. Программа завершается");
        break;
    }

    int Number = Convert.ToInt32(NumberString);
    int sum = DoNumberSumm(Number);
    if (NumberString == "q" || sum % 2 == 0)
    {
        Console.WriteLine("Cумма цифр числа четная. Программа завершается");
        break; 
    }
    else
    {
        Console.WriteLine($"Сумма чисел равна {sum}");
    }
}






