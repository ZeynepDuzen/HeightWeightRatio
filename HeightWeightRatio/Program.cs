using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeightWeightRatio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // *** Height and Weight ratio ***

            Heading();
            double height = Start("How tall are you ? ");
            double weight = Start("What's your weight ? ");
            double ratio = RatioCalculation(height,weight);
            Console.WriteLine("Your height and weight ratio is : " + ratio);
            RatioResult(ratio);


            Console.Read();
        }

       
        static double RatioCalculation(double height,double weight)
        {
            double ratio = weight / (height * height);
            return ratio;
        }
        static void RatioResult(double ratio)
        {
            Console.Write("Your height and weight ratio is : ");
            if (ratio < 18)
                Console.WriteLine("Weak");
            if (ratio >= 18 && ratio < 25)
                Console.WriteLine("Normal");
            if (ratio >= 25 && ratio < 30)
                Console.WriteLine("Fat");
            if (ratio >= 30 && ratio < 35)
                Console.WriteLine("Obese");
            
        }
        static void Heading()
        {
            Console.WriteLine("*** Height and Weight Ratio ***");
            Console.WriteLine();
            Console.WriteLine("You should use < , > if you need it");
            Console.WriteLine();
        }
        
        static double Start(string message)
        {
            double start;
            Console.WriteLine(message);
            start = Convert.ToDouble(Console.ReadLine());
            return start;
        }
    }
}
