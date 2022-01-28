using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison
{
    public class LineComputation
    {
        public int ReadCoordinateX()
        {
            int x;
            return x = Convert.ToInt32(Console.ReadLine());
        }

        public int ReadCoordinateY()
        {
            int y;
            return y = Convert.ToInt32(Console.ReadLine());
        }

        public double CalcLength(int x1, int x2, int y1, int y2)
        {
            double length;
           return length = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
        }
        public void ComputeLines()
        {
            Console.WriteLine("----- Line1 Details -----");
            Console.WriteLine("Enter the (x1,y1) co-ordinates: ");
            int x1 = ReadCoordinateX(); int y1 = ReadCoordinateY();

            Console.WriteLine("Enter the (x2,y2) co-ordinates: ");
            int x2 = ReadCoordinateX(); int y2 = ReadCoordinateY();

            Console.WriteLine("----- Line2 Details -----");
            Console.WriteLine("Enter the (x3,y3) co-ordinates: ");
            int x3 = ReadCoordinateX(); int y3 = ReadCoordinateY();

            Console.WriteLine("Enter the (x4,y4) co-ordinates: ");
            int x4 = ReadCoordinateX(); int y4 = ReadCoordinateY();

            double firstLineLength = CalcLength(x1, x2, y1, y2);
            double secondLineLength = CalcLength(x3, x4, y3, y4);

            if(firstLineLength == secondLineLength)
            {
                Console.WriteLine($"Line1 having length = {firstLineLength} and Line2 having length = {secondLineLength} are EQUAL !");
            }
            if(firstLineLength > secondLineLength)
            {
                Console.WriteLine($"Line1 having length = {firstLineLength} is greater than Line2 having length = {secondLineLength} !");
            }
            if(firstLineLength < secondLineLength)
            {
                Console.WriteLine($"Line1 having length = {firstLineLength} is lesser than Line2 having length = {secondLineLength} !");
            }

        }
    }
}
