//Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа.

int ShowSecond (int num)
{
    int second = (num / 10) % 10;
    return second;
}

Console.Write("Ввведите трехзначное число: ");

int number = Convert.ToInt32(Console.ReadLine());



if ((number/100) < 10 & (number/100) != 0)
{
    Console.WriteLine("Второе число :  "+ ShowSecond(number));
}
else
{
    Console.Write(number+ " - не трехзначное");
}

