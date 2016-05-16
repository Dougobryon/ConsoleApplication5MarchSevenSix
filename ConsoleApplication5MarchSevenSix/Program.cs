using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5MarchSevenSix
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter Starting Number Here");
            int startingNum  = int.Parse(Console.ReadLine());
            // int n startingNum = 2;


            Console.WriteLine("Enter Ending Number Here");
            int endingNum = int.Parse(Console.ReadLine());
           // int m endingNum = 6;
      

            decimal product = 1;
            int n = startingNum;

            do
            {
                if (n > endingNum)
                {
                    break;

                }
                product *= n;
                n++;
}
            while (true);

            Console.WriteLine("The product of this range is = " + product);
        }
    }
}
