using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecaVictory
{
    class Generics_MethodGroupConversion
    {
        //C# in Depth 2ed - Listing 3.2 - Page 67
        //Method Group Conversion
        static double TakeSquareRoot(int x)
        {
            return Math.Sqrt(x);
        }
        static void Main(string[] args)
        {
            //Step 1. List Population - Strongly Typed List of Integers
            List<int> integers = new List<int>();
            integers.Add(1);
            integers.Add(2);
            integers.Add(3);
            integers.Add(4);

            //Step 2. Method Group Conversion - New Feature in C# 2.0
            Converter<int, double> converter = TakeSquareRoot;

            //Step3. 
            List<double> doubles;
            doubles = integers.ConvertAll<double>(converter);

            foreach (double d in doubles)
            {
                Console.WriteLine(d);
            }

            Console.Read();
        }
    }
}
