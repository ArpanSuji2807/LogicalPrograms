using LogicalPrograms;
Console.WriteLine("Hello welcome to my program");
bool end = true;
Console.WriteLine("1.Fibonacci Series");
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
            Console.WriteLine("Enter a valid choice");
            end = false;
            break;
        default:
            break;
    }
}