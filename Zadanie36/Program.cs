// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

int[] NewArray = GetArray(17, -10, 10);

int NewSum = GetSum(NewArray);

Console.Write("[");
Console.Write(string.Join(", ", NewArray));
Console.Write("]");
Console.WriteLine(" ");
Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях = {NewSum}");


int[] GetArray(int length, int min, int max)
{
    int[] array = new int[length];
    Random num = new Random();

    for(int index = 0; index < length; index ++)
    {
        array[index] = num.Next(min, max +1);
    }

return array;
}


int GetSum(int[] array)
{
    int sum = 0;

    for(int i = 0; i < array.Length; i ++)
    {
        if(i % 2 != 0)
        {
            sum = sum + array[i];
        }
    }

    return sum;
}