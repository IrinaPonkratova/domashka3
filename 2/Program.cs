//Напишите программу, которая выводит третью 
//цифру заданного числа или сообщает, что третьей цифры нет.
//домашка 2 задача 
System.Console.WriteLine("введите число");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 99 && number < 1000)
{
    int threeNumber = number % 10;
    System.Console.WriteLine($"третья цифра {threeNumber}");
}
else if (number < 100)
{
    System.Console.WriteLine("третьей цифры нет");
}
else 
{
    while (number > 1000)
    {
        number = number / 10; 
    }
    int threeNumber = number % 10;
    System.Console.WriteLine($"третья цифра {threeNumber}");
}