/*Напишите программу, которая выводит третью цифру заданного числа 
или сообщает, что третьей цифры нет.*/



Console.WriteLine("введите число ");
int num = Convert.ToInt32(Console.ReadLine());

int a = Math.Abs(num);
string stringNum = Convert.ToString(a);

if (stringNum.Length < 3)
{
    Console.WriteLine ("Третьей цифры нет.");
}
else
{
    Console.WriteLine ("Третья цифра этого числа " + stringNum[2]);
}