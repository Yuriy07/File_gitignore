// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1


int Promt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int number = Promt("Введите трезначное число: ");

if(number >= 100 & number < 1000)
{
    int mid = (number % 100 - number % 10) / 10;
    Console.WriteLine($"Вторая цфира числа {number} является {mid}");
}
else
{
    Console.WriteLine("Это число не трехзначное");
}