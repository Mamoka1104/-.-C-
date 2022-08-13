{
    while (true)
    {

    Console.WriteLine("Введите трёхзначное число или 'q' для выхода");
    string num = Console.ReadLine();
    if (num == "q")
    {
    break;
    }
     if (num.Length == 3)
    { 
    Console.WriteLine("Вторая цифра числа: " + num[1]); 
    }
    else
     {
    Console.WriteLine("Вы ввели не трёхзначное число");
    }
    }
}