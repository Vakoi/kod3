using System;

class Program
{
    static void Main(string[] args)
    {
        int number = 96; // замените на нужное значение

        int firstDigit = number / 10;
        int secondDigit = number % 10;

        int sum = firstDigit + secondDigit;
        int product = firstDigit * secondDigit;

        Console.WriteLine("Сумма цифр: " + sum);
        Console.WriteLine("Произведение цифр: " + product);
    }
}
