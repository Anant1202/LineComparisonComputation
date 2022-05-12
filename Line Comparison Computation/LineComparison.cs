using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisonComputation
{
    public class LineComparison
    {
        public void LengthOfLine()
        {
            //Line 1 Length Calculation
            Console.WriteLine("Enter the value of x and y for point 1");
            Console.Write("x1:");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("y1:");
            int y1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the value of x and y for point 2");
            Console.Write("x2:");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("y2:");
            int y2 = Convert.ToInt32(Console.ReadLine());
            double Power1 = Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2);
            double Line1 = Math.Sqrt(Power1);
            Console.WriteLine("Length of the line 1 is " + Line1);

            //Line 2 Length Calculation
            Console.WriteLine("---------------------");
            Console.WriteLine("Enter the value of x and y for point 3");
            Console.Write("x3:");
            int x3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("y3:");
            int y3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the value of x and y for point 4");
            Console.Write("x4:");
            int x4 = Convert.ToInt32(Console.ReadLine());
            Console.Write("y4:");
            int y4 = Convert.ToInt32(Console.ReadLine());
            double Power2 = Math.Pow(x4 - x3, 2) + Math.Pow(y4 - y3, 2);
            double Line2 = Math.Sqrt(Power2);
            Console.WriteLine("Length of the line 2 is " + Line2);


            //if (x1 == x3 && y1 == y3)
            //{
            //    if (x2 == x4 && y2 == y4)
            //    {
            //        Console.WriteLine("Both lines are equal");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Lines are not equal");
            //}



            if (Line1.Equals(Line2) == true)
            {
                Console.WriteLine("Both lines are equal");
            }
            else
            {
                Console.WriteLine("Both lines are not equal");


                if (Line1.CompareTo(Line2) > 0)
                {
                    Console.WriteLine("Line1 is greater than Line2");
                }
                else
                {
                    Console.WriteLine("Line2 is greater than Line1");
                }
            }

        }
    }
}
    
