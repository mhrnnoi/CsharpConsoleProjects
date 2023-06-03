using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bmi
{
    public class BmiCalc
    {
        

        public static string Bmi(double height, double weight)
        {
            if (height > 5)
            {
                height /= 100;
            }
            var bmi = weight / Math.Pow(height, 2);

            if (bmi > 40)
            {
                return string.Format($" your Bmi is {bmi} Very severely obese");
            }
            else if (bmi > 35)
            {
                return string.Format($" your Bmi is {bmi} severely obese");
            }
            else if (bmi > 30)
            {
                return string.Format($" your Bmi is {bmi} moderetely obese");
            }
            else if (bmi > 25)
            {
                return string.Format($" your Bmi is {bmi} overweight");
            }
            else if (bmi > 18.5)
            {
                return string.Format($" your Bmi is {bmi} normal");
            }
            else if (bmi > 16)
            {
                return string.Format($" your Bmi is {bmi} underweight");
            }
            else if (bmi > 15)
            {
                return string.Format($" your Bmi is {bmi} severely under weight");
            }
            else
            {
                return string.Format($" your Bmi is {bmi} very severely under weight");
            }

        }
    }
}