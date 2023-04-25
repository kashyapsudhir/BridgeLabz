using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    public class LeapYear
    {
        public static void CheckLeapYear()
        {
            
           Console.WriteLine("Enter your Valid Year");
            
           int Year = Convert.ToInt32(Console.ReadLine());
           
           if ((Year > 999) && (Year<10000))
            {

                if ((Year % 4) == 0 && (Year % 100) == 0)
                    Console.WriteLine("is a leap year.{0}", Year);
                else if ((Year % 100) == 0)
                    Console.WriteLine(" is not a leap year.{0}", Year);
                else if ((Year % 4) == 0)
                    Console.WriteLine(" is a leap year.{0}", Year);
                else
                    Console.WriteLine(" is not a leap year.{0}", Year);
            }
           else 
            {
                Console.WriteLine("Year is not valid");
            }
        }
    }
    
}
