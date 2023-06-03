using System;


namespace new4
{
    
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("welcome to bmi calculator !!");

            Console.WriteLine("plz enter your weight and height to calculate your bmi");

            Console.WriteLine("weight in kg : ");
            var weight =Convert.ToDouble( Console.ReadLine());
            Console.WriteLine("height in m: ");
            var height=Convert.ToDouble( Console.ReadLine());
            var bmi = weight/(Math.Pow(height,2));
            if (bmi < 16 && bmi >= 8 )
            {
                Console.WriteLine(bmi);
                Console.WriteLine("Severe Thinness	");
            }
            else if (bmi >= 16 && bmi <17)
            {
                Console.WriteLine(bmi);
                Console.WriteLine("Moderate  Thinness	");
            }
            else if (bmi >= 17  && bmi <18.5)
            {
                Console.WriteLine(bmi);
                Console.WriteLine("Mild  Thinness	");
            }
            else if (bmi >= 18.5  && bmi <25 )
            {
                Console.WriteLine(bmi);
                Console.WriteLine("Normal	");
            }
            else if (bmi >= 25  && bmi <30 )
            {
                Console.WriteLine(bmi);
                Console.WriteLine("Overweight	");
            }
            else if (bmi >= 30  && bmi <35 )
            {
                Console.WriteLine(bmi);
                Console.WriteLine("Obese Class I		");
            }
            else if (bmi >= 35  && bmi <40 )
            {
                Console.WriteLine(bmi);
                Console.WriteLine("Obese Class II		");
            }
            else if (bmi >= 40  && bmi <55 )
            {
                Console.WriteLine(bmi);
                Console.WriteLine("Obese Class III		");
            }
            else 
            {
                Console.WriteLine(bmi);
                Console.WriteLine("you entered invalid inputs");
            }
        }
    }
}
