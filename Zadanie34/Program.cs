// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2



int[] newArray = GetRandomArray(20, 100, 999);

int count = GetCount(newArray);
Console.Write("[");
Console.Write(string.Join(", ", newArray));
Console.Write("]");
Console.WriteLine(" ");
Console.WriteLine($"В заданном массиве {count} четных чисел");

int[] GetRandomArray(int length, int min, int max)
{
    int[] array = new int[length];
    Random num = new Random();

    for(int index = 0; index < array.Length; index ++)
    {
        array[index] = num.Next(min, max +1 );
    }

    return array;
}

int GetCount(int[] array)
{
int count = 0;


for(int i = 0; i < array.Length; i ++ )
{
    if (array[i] % 2 == 0)
    {
        count++;
    }
}

return count;

}

