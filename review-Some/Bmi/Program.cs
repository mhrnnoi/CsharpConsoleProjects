using System;

namespace Bmi
{
    class Program
    {
        static void Main(string[] args)
        {

            if (!(args.Length < 1))
            {
                switch (args[0])
                {
                    case "bmi":
                        switch (args.Length)
                        {
                            case 1:
                                Console.WriteLine("invalid command");
                                Console.WriteLine("use --helps to show helps");
                                break;
                            case 2:
                                switch (args[1])
                                {
                                    case "--helps":
                                        Console.WriteLine("use these to run program");
                                        Console.WriteLine("--height \t your height (meter or cm)");
                                        Console.WriteLine("--weight \t your weight (kg)");
                                        Console.WriteLine("--version \t your version");
                                        Console.WriteLine("--helps \t command list");
                                        break;

                                    case "--version":
                                        Console.WriteLine("v1.2");
                                        break;

                                    default:
                                        Console.WriteLine("invalid command");
                                        Console.WriteLine("use --helps to show helps");
                                        break;
                                }
                                break;
                            case 5:

                                switch (args[1])
                                {
                                    case "--height":

                                        if (!(args[3] == "--weight") || double.TryParse(args[2], out double height) == false || double.TryParse(args[4], out double weight) == false)
                                        {
                                            Console.WriteLine("invalid command");
                                            Console.WriteLine("use --helps to show helps");

                                        }
                                        else
                                        {
                                            height = Convert.ToDouble(args[2]);
                                            weight = Convert.ToDouble(args[4]);
                                            Console.WriteLine(BmiCalc.Bmi(height, weight));
                                        }


                                        break;

                                    case "--weight":



                                        if (!(args[3] == "--height") || double.TryParse(args[2], out double weight2) == false || double.TryParse(args[4], out double height2) == false)
                                        {
                                            Console.WriteLine("invalid command");
                                            Console.WriteLine("use --helps to show helps");

                                        }
                                        else
                                        {
                                            height2 = Convert.ToDouble(args[4]);
                                            weight2 = Convert.ToDouble(args[2]);
                                            Console.WriteLine(BmiCalc.Bmi(height2, weight2));
                                        }


                                        break;

                                    default:
                                        Console.WriteLine("invalid command");
                                        Console.WriteLine("use --helps to show helps");
                                        break;
                                }
                                break;


                            // else
                            //         {



                            //         case "--height":
                            //         if (!(args.Length == 5))
                            //         {
                            //             Console.WriteLine("invalid command");
                            //             Console.WriteLine("use --helps to show helps");
                            //         }

                            //         height = Convert.ToDouble(args[2]);
                            //         weight = Convert.ToDouble(args[4]);



                            //         Console.WriteLine(BmiCalc.Bmi(height, weight));
                            //         break;
                            //     case "--weight":
                            //         if (!(args.Length == 5))
                            //         {
                            //             Console.WriteLine("invalid command");
                            //             Console.WriteLine("use --helps to show helps");
                            //         }

                            //         height = Convert.ToDouble(args[4]);
                            //         weight = Convert.ToDouble(args[2]);


                            //         Console.WriteLine(BmiCalc.Bmi(height, weight));

                            //         break;

                            default:
                                Console.WriteLine("invalid command");
                                Console.WriteLine("use --helps to show helps");
                                break;







                        }

                        break;
                    default:
                        Console.WriteLine("invalid command");
                        Console.WriteLine("use --helps to show helps");
                        break;

                }


            }
            else
            {
                Console.WriteLine("invalid command");
                Console.WriteLine("use --helps to show helps");
            }
        }
    }
}