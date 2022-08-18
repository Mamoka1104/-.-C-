int number(string num)
{
   Console.Write($"Введите число {num}: ");
   return Convert.ToInt32(Console.ReadLine());
}
int A = number("A");
int B = number("B");

int pow = 1;
for(int i = 0; i < B; i++)
{
    pow *= A;
}
Console.WriteLine($"{A} ^ {B} = {pow}");