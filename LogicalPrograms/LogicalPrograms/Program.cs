﻿using LogicalPrograms;
Console.WriteLine("Hello welcome to my program");
bool end = true;
Console.WriteLine("1.Fibonacci Series\n2.Perfect Number\n3.Prime Number\n4.Palindrome number\n5.Day Of week");
while (end)
{
    Console.WriteLine("Choose an option");
    int option = Convert.ToInt32(Console.ReadLine());
    switch (option)
    {
        case 1: 
            FibonacciSeries series = new FibonacciSeries();
            series.Series();
            break;
        case 2:
            PerfectNumber number = new PerfectNumber();
            number.Number();
            break;
        case 3:
            PrimeNumber number1 = new PrimeNumber();
            number1.Prime();
            break;
        case 4:
            ReverseNumber number2 = new ReverseNumber();
            number2.Palindrome();
            break;
        case 5:
            WeekDays number3 = new WeekDays();
            number3.Day();
            break;
        case 6:
            Console.WriteLine("Enter a valid choice");
            end = false;
            break;
        default:
            break;
    }
}