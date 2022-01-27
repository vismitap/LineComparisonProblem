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
            Console.WriteLine("Enter the (x1,y1) co-ordinates: ");
            int x1 = Convert.ToInt32(Console.ReadLine());
            int y1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the (x2,y2) co-ordinates: ");
            int x2 = Convert.ToInt32(Console.ReadLine());
            int y2 = Convert.ToInt32(Console.ReadLine());

            double length = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            Console.WriteLine("The length of the line is: "+length);
        }
    }
}
