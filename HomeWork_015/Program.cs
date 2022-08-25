/* Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */


Random rand = new Random();
int sum = 0;

Console.WriteLine("Сколько чисел вы хотите ввести?");

int numberCount = Convert.ToInt32(Console.ReadLine());
int[] array = new int[numberCount];

Console.Write("[");

for (int i = 0; i < numberCount; i++)
{
    array[i] = rand.Next(100);
    Console.Write(array[i]);
    
    if (i != numberCount - 1)
    {
        Console.Write(", ");
    }

}

Console.Write("]");

for (int k = 0 ; k < numberCount; k += 2)
{
    sum = sum + array[k];
}
Console.WriteLine("Сумма значений - " + sum);