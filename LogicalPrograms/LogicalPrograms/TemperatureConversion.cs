using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class TemperatureConversion
    {
        public void Conversion()
        {
            Console.WriteLine("Enter your choice: 1.Celcius to Farenheit 2.Farenheit to Celcius");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("Enter the Celcius value");
                    double c1 = Convert.ToInt32(Console.ReadLine());
                    double f1 = (c1 * 9 / 5) + 32;
                    Console.WriteLine("Farenheit value is : " + f1);
                    break;
                case 2:
                    Console.WriteLine("Enter the Farenheit value");
                    double f2 = Convert.ToInt32(Console.ReadLine());
                    double c2 = (f2 - 32) * 5 / 9;
                    Console.WriteLine("Farenheit value is : " + c2);
                    break;
                default:
                    Console.WriteLine("Enter a valid choice");
                    break;
            }
        }
    }
}
