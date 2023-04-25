using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    public class FlipCoin
    {
        public static void DisplayPerecentage()
        {
            //int Head = 0;
            //int tail = 0;
            int HeadCount = 0;
            int tailCount = 0;

            double HeadPercentage;
            double tailPercentage;

            int flipCoin = Convert.ToInt32(Console.ReadLine());
            if (flipCoin >= 0)
            {
                for(int i = 1; i <= flipCoin; i++)
                {
                    Random random = new Random();
                    int number = random.Next(2);
                    Console.WriteLine(  "the Random function is " + number);
                    if(number==1)
                    {
                        HeadCount++;
                    }
                    else if(number==0)
                    {
                        tailCount++;
                    }
                    //switch(number)
                    //{
                    //    case 1:
                    //        HeadCount++;
                    //        break;
                    //    case 0:
                    //        tailCount++;
                    //        break;
                    //}
               

                }
                Console.WriteLine(  "The Head count is"+ " " + HeadCount);
                Console.WriteLine("The Tail count is"+ " " + tailCount);

                HeadPercentage = HeadCount * 100 / flipCoin;
                tailPercentage = tailCount * 100 / flipCoin;

                Console.WriteLine("The Head Percentage : {0}",HeadPercentage+"%");
                Console.WriteLine("The tail Percentage :" + tailPercentage+"%");

            }
        }
    }
}
