//Напишите программу, которая перевернёт одномерный массив (первый элемент станет последним, второй – предпоследним и т.д.)
int[] ArrayInput()
{
    Console.WriteLine("Введите размер массива");
    int ArrayLenght = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[ArrayLenght];
    int i = 0;
    while (i < ArrayLenght)
    {
        Console.WriteLine($"Введите {i + 1}-е число:");
        array[i] = Convert.ToInt32(Console.ReadLine());
        i++;
    }
    return array;
}

int[] array = ArrayInput();

Console.Write($"Ваш массив ");
Console.WriteLine(" ");

foreach (int value in array)
{
    Console.Write($"{value}, ");
}

int min = 0;
int max = array.Length;
int digit1=0;
int digit2=0;  
{
    while (max>min)
    {
        digit1= array[max-1];
        digit2= array[min];
        array[max-1]=digit2;
        array[min]=digit1;
        max--;
        min++;
    }
}

Console.WriteLine(" ");
Console.WriteLine($"Ваш зеркальный массив ");

foreach (int vb in array)
{
    Console.Write($"{vb}, ");
}