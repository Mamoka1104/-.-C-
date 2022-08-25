/* Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76 */

int maxNumberArray(int[] array)
{
    int max = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > max)
        {
            max = array[i];
        }
    }
    return max;
}

int mimNumberArray(int[] array)
{
    int min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] < min)
        {
            min = array[i];
        }
    }
    return min;
}

{
    int[]array = {3, 7, 22, 2, 78};
    int max = maxNumberArray(array);
    int min = mimNumberArray(array);
    Console.WriteLine(max);
    Console.WriteLine(min);
    Console.WriteLine(max - min);
}