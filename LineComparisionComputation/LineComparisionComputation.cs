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
            //displying number of Line
            Console.WriteLine("First Point ({0},{1})",x1,x2);
            Console.WriteLine("Second Point ({0},{1})", y1, y2);
            //calculate length of two point
            double Line1 =Math.Sqrt(Math.Pow((x2-x1), 2)+ Math.Pow((y2-y1),2));
            Console.WriteLine("Length Of Line :" +Line1);
        }
    }
}
