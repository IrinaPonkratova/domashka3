// домашка 1 задача
System.Console.WriteLine("введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 99 && number < 1000)
{
    int secondNumber = ((number / 10) % 10);
    System.Console.WriteLine($"вторая цифра числа {number} равна {secondNumber}");
}
else 
{
    System.Console.WriteLine("это число не трехзначное");
}