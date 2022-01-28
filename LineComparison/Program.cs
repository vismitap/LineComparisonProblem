using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("************Welcome to Line Comparison Problem!************\n");
            LineComputation line1 = new LineComputation(1, 2, 3, 4);
            double firstLineLength = line1.CalcLength();
            LineComputation line2 = new LineComputation(4, 2, 7, 4);
            double secondLineLength = line2.CalcLength();

            if (firstLineLength.Equals(secondLineLength))
            {
                Console.WriteLine($"Line1 having length = {firstLineLength} and Line2 having length = {secondLineLength} are EQUAL. \n");
            }
            if (firstLineLength.CompareTo(secondLineLength) > 0)
            {
                Console.WriteLine($"Line1 having length = {firstLineLength} is GREATER than Line2 having length = {secondLineLength}. \n");
            }
            else
            {
                Console.WriteLine($"Line1 having length = {firstLineLength} is LESSER than Line2 having length = {secondLineLength}. \n");
            }
        }
    }
}
