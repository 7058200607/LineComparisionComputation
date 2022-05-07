using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisionComputation
{
    public class LineComparisionComputation
    {
        public void LineComputation() 
        {
            Console.WriteLine("Enter a x,y coordinates for Line1");
            Console.Write("x1:");
            int x1 =Convert.ToInt32(Console.ReadLine());
            Console.Write("y1:");
            int y1 =Convert.ToInt32(Console.ReadLine());
            Console.Write("x2:");
            int x2 =Convert.ToInt32(Console.ReadLine());
            Console.Write("y2:");
            int y2 =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a x,y coordinates for Line2");
            Console.Write("x3:");
            int x3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("y3:");
            int y3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("x4:");
            int x4 = Convert.ToInt32(Console.ReadLine());
            Console.Write("y4:");
            int y4 = Convert.ToInt32(Console.ReadLine());
            //displying number of Line
            Console.WriteLine("First Point ({0},{1})",x1,x2);
            Console.WriteLine("Second Point ({0},{1})", y1, y2);
            Console.WriteLine("First Point ({0},{1})", x3, x4);
            Console.WriteLine("Second Point ({0},{1})", y3, y4);
            //calculate length of two point
            double Line1 =Math.Sqrt(Math.Pow((x2-x1), 2)+ Math.Pow((y2-y1),2));
            Console.WriteLine("Length Of Line1 :" +Line1);
            double Line2 = Math.Sqrt(Math.Pow((x4 - x3), 2) + Math.Pow((y4 - y3), 2));
            Console.WriteLine("Length Of Line2 :" + Line1);
        }
    }
}
