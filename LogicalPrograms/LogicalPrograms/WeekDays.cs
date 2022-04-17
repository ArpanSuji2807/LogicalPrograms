using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class WeekDays
    {
        public void Day()
        {
            Console.WriteLine("Enter a month from 1 to 12: ");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a day from 1 to 30: ");
            int day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a year(4 digits): ");
            int year = Convert.ToInt32(Console.ReadLine());
            int y0 = year - (14 - month) / 12;
            int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
            int m0 = month + 12 * ((14 - month) / 12) - 2;
            int d0 = (day + x + 31 * m0 / 12) % 7;
            switch (d0)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Enter a valid choice");
                    break;
            }
        }
    }
}
