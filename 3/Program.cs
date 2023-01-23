//домашка 3 задача
//Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, 
//и проверяет, является ли этот день выходным.
Console.WriteLine("введите число");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 0 && number < 8)
{
    if (number == 6 || number == 7)
    {
        System.Console.WriteLine("да");
    }
    else{
        System.Console.WriteLine("нет");
    }
}
else{
    System.Console.WriteLine("это не день недели");
}