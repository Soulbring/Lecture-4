    int sum = 0;
    int digit = 0;
    int Number = 15252;

    while(Number > 0)
    {
        digit = Number % 10;
        sum = sum + digit;
        Number = Number / 10;
    }
    Console.WriteLine(sum);
