// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементом массива.

// [3 7 22 2 78] -> 76


double[] GiveArray = GetArray(10, -5, 15);

double[] MinMax = MinAndMax(GiveArray);

double GetDif = GetDifference(MinMax);


Console.Write("[");
Console.Write(string.Join(", ", GiveArray));
Console.Write("]");
Console.WriteLine(" ");

Console.Write("Минимальное и максимальное значения массива равны = ");
Console.Write(string.Join(", ", MinMax));
Console.WriteLine(" ");

Console.WriteLine($"Разница между максимальным и минимальным значением массива = {GetDif}");



double[] GetArray(int length, int min, int max)
{
    double[] array = new double[length];
    Random num = new Random();

    for(int i = 0; i < array.Length; i ++)
    {
        array[i] = num.Next(min, max + 1);
    }

    return array;
}




double[] MinAndMax(double[] array)
{
    double[] newArray = new double[2];
    Random num = new Random();

    double posMin = array[0];
    double posMax = array[0];

  
    for(int count = 0; count < array.Length; count ++)
    {
        if(array[count] <= posMin)
        {
            posMin = array[count];
            
            newArray[0] = posMin;
        }
        else
        {
            if(array[count] >= posMax)
            {
                posMax = array[count];

                newArray[1] = array[count];
            }
        }
    }

return newArray;

}




double GetDifference(double[] newArray)
{
    
double dif = newArray[1] - (newArray[0]);

return dif;

}

