using System;
using System.Linq;
namespace BMI_cli
{
    class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine(BmiCalc(args));
        }
        public static string BmiCalc(string[] args)
        {
            const string help = "--helps";
            const string version = "--version";
            const string weight = "--weight";
            const string height = "--height";

            string bmistr = null;
            string versionStr = "1.0";

            double weightDouble;
            double heightDouble;
            double bmi;

            if (args.Length > 0)
            {


                if (args[0].ToLower() == "bmi")
                {
                    if (args.Length > 1)
                    {
                        switch (args[1].ToLower())
                        {
                            case help:
                                return ($"Options: \n{height}          Your height(m) \n{weight}          Your weight(kg) \n{version}         Show current version \n{help}           Show command list".ToString());

                            case version:
                                return ($"Current version is: {versionStr}").ToString();

                            case weight:
                            case height:
                                if (args.Contains(height) && args.Contains(weight))
                                {
                                    weightDouble = double.Parse(args[(Array.IndexOf(args, weight)) + 1]);
                                    heightDouble = double.Parse(args[(Array.IndexOf(args, height)) + 1]);
                                    bmi = weightDouble / Math.Pow(heightDouble, 2);

                                    if (bmi < 18.5)
                                    {
                                        bmistr = "Severe Thinness";
                                    }
                                    else if (bmi >= 18.5 && bmi < 25)
                                    {
                                        bmistr = "Normal";

                                    }
                                    else if (bmi >= 25 && bmi < 30)
                                    {
                                        bmistr = "Overweight";

                                    }
                                    else if (bmi >= 30)
                                    {
                                        bmistr = "Obese";

                                    }
                                    return ($"Your BMI Score is: \n{string.Format("{0:0.00}", bmi)} \nYour Status is: {bmistr}".ToString());
                                }
                                else
                                {
                                    return ($"invalid command \nEnter bmi {help}").ToString();
                                }


                            default:
                                return ($"Invalid command \nEnter bmi {help}").ToString();

                        }

                    }
                    else
                    {
                        return ($"options: \n{version}   current version \n{help}    show command list").ToString();

                    }

                }
                else
                {
                    return ($"Invalid command \nEnter bmi {help} to show help").ToString();
                }





            }
            else
            {
                return "Invalid command \nEnter bmi --helps to show help";
            }
        }

        }
    }
