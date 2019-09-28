using System;
using System.Globalization;

namespace Currency_Format_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            double number1, number2, number3, sum, mean;

            Console.WriteLine("Enter the first number:");
            number1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            number2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the third number:");
            number3 = Convert.ToDouble(Console.ReadLine());

            sum = (number1 + number2 + number3); //total before currency applied
            mean = (sum / 3); //mean

            //converting to US dollar, Janpense Yen, Swedish Kornor, and Thai Baht
            Console.WriteLine("US: {0}", sum.ToString("C", CultureInfo.CurrentCulture));
            Console.WriteLine("Japan: {0}", sum.ToString("C", CultureInfo.CreateSpecificCulture(("ja-JP"))));
            Console.WriteLine("Swedish: {0}", sum.ToString("C2", CultureInfo.CreateSpecificCulture(("da-DK"))));
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Thai: {0}", sum.ToString("C", CultureInfo.CreateSpecificCulture(("th-TH"))));

            //mean
            Console.WriteLine("The mean is {0}.", mean);

            //smallest number
            Console.WriteLine("Lowest Number: " + Math.Min(number1, Math.Min(number2, number3)));

            //largest number
            Console.WriteLine("Largest Number: " + Math.Max(number1, Math.Max(number2, number3))); 

            
        }
    }
}
