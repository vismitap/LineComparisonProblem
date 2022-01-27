using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison
{
    public class LineComputation
    {
        public void ComputeLines()
        {
            Console.WriteLine("----- Line1 Details -----");
            Console.WriteLine("Enter the (x1,y1) co-ordinates: ");
            int x1 = Convert.ToInt32(Console.ReadLine());
            int y1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the (x2,y2) co-ordinates: ");
            int x2 = Convert.ToInt32(Console.ReadLine());
            int y2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("----- Line2 Details -----");
            Console.WriteLine("Enter the (x3,y3) co-ordinates: ");
            int x3 = Convert.ToInt32(Console.ReadLine());
            int y3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the (x4,y4) co-ordinates: ");
            int x4 = Convert.ToInt32(Console.ReadLine());
            int y4 = Convert.ToInt32(Console.ReadLine());

            double firstLineLength = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            double secondLineLength = Math.Sqrt(Math.Pow((x4 - x3), 2) + Math.Pow((y4 - y3), 2));

            if(firstLineLength == secondLineLength)
            {
                Console.WriteLine("Line1 and Line2 are EQUAL!");
            }
            else
            {
                Console.WriteLine("Line1 and Line2 are UNEQUAL!");
            }

        }
    }
}
