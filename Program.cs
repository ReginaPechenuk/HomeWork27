// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

int getUserData (string massage)
{
    Console.WriteLine(massage);
    int userData = int.Parse(Console.ReadLine()!);
    return userData;
}

int getSumNumbers (int number)
{
        int sum = 0;
        int digit1 = number / 10000;
        int digit2 = (number - digit1*10000)/ 1000;
        int digit3 = (number - digit1*10000 - digit2*1000)/100;
        int digit4 = (number - digit1*10000-digit2*1000-digit3*100)/10;
        int digit5 = number % 10;
        sum = digit1 + digit2 + digit3 + digit4 + digit5;
        return sum;
    }


int number = getUserData("Введите число от 1 до 99999");
int sum = getSumNumbers(number);
Console.WriteLine($"Сумма цифр в числе = {sum}");
