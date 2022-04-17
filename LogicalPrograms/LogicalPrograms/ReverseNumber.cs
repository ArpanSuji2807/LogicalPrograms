using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class ReverseNumber
    {
        int rem = 0, rev = 0;
        public void Palindrome()
        {
            Console.WriteLine("Enter the value");
            int num = Convert.ToInt32(Console.ReadLine());
            while (num > 0)
            {
                rem = num % 10;
                num = num / 10;
                rev = rev * 10 + rem;
            }
            Console.WriteLine("The reverse number is: " + rev);
        }
    }
}
