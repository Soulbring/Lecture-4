//Задайте массив заполненный случайными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.




Console.WriteLine("Введите колличество чисел в массиве");
int ArrayLenght = Convert.ToInt32(Console.ReadLine());
int e = 0;
Random rnd = new Random();
 int[] array = new int[ArrayLenght];
 while(e < ArrayLenght )
 {
    array[e] = rnd.Next(100, 1000);
    Console.Write($"{array[e]} ");
    e++;
    
 }

int ShowEvenNumber (int[] arr)
{
    int sum = 0;
    for(int i = 0; i < arr.Length;i++)
    {
        if(arr[i] % 2 == 0)
        {
            sum++;
        }
    }
    return sum;
}

int sum = ShowEvenNumber(array);

Console.WriteLine($"Количество четных чисел {sum}");
