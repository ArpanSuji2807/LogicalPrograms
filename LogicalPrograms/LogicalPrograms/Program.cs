using LogicalPrograms;
Console.WriteLine("Hello welcome to my program");
bool end = true;
Console.WriteLine("1.Fibonacci Series\n2.Perfect Number");
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
            Console.WriteLine("Enter a valid choice");
            end = false;
            break;
        default:
            break;
    }
}