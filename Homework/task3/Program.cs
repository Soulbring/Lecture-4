int ShowEvenNumber = (int array)
{
    int sum = 0;
    for(int i = 0; i < array.Length;i++)
    {
        if(array[i] % 2 == 0)
        {
            sum++;
        }
    }
    return sum;
}


 Console.WriteLine($"Количество четных чисел {ShowEvenNumber = (sum)}");