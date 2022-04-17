using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class MonthlyPayment
    {
        public void Payment()
        {
            Console.WriteLine("Enter the no. of years: ");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Principal amount: ");
            int principal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Rate of interest: ");
            int rate = Convert.ToInt32(Console.ReadLine());
            double rateOfInterest = rate / 1200;
            int num1 = 12 * year;
            double payment = ((principal * rateOfInterest) / (1 - Math.Pow((1 + rateOfInterest), 1 / num1)));
            Console.WriteLine("Monthly payment is: " + payment);
        }
    }
}
