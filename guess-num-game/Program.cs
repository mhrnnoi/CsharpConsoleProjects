using System;

namespace Guess_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello this is a simple  fun game!!!");
            Console.WriteLine("in this game you have to guess a number betwean 1-100 ");
            Console.WriteLine("i will say its higher than or lower than my secret number and finally say its correct.");
            var randGen = new Random();
            int num ;
            int guess;
            int guessOld ;
            int counter ;
            bool yesOrNo;



            do
            {
                num = randGen.Next(1, 101);
                guessOld = num;
                counter = 0;
                
                do
                {

                    Console.Write("guess a num between 1 - 100: ");
                    guess = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("guess : " + guess);
                    counter++;
                    if (counter == 1)
                    {
                        if (guess > num)
                        {
                            Console.WriteLine("{0} is higher than mine", guess);
                        }

                        else
                        {
                            Console.WriteLine("{0} is lower than mine", guess);
                        }
                    }
                    else
                    {
                        if (Math.Abs(guess - num) < 5)
                        {
                            Console.WriteLine("almost there");
                            if (guess > num)
                            {
                                Console.WriteLine("{0} is higher than mine", guess);
                            }
                            else
                            {
                                Console.WriteLine("{0} is lower than mine", guess);


                            }
                        }
                        else
                        {
                            if (Math.Abs(guess - num) < Math.Abs(guessOld - num))
                            {
                                Console.WriteLine("{0} is closer!!", guess);
                                if (guess > num)
                                {
                                    Console.WriteLine("and {0} is higher than mine", guess);
                                }
                                else
                                {
                                    Console.WriteLine("and {0} is lower than mine", guess);


                                }

                            }
                            else
                            {
                                Console.WriteLine("{0} is farther!!", guess);
                                if (guess > num)
                                {
                                    Console.WriteLine("and {0} is higher than mine", guess);
                                }
                                else
                                {
                                    Console.WriteLine("and {0} is lower than mine", guess);


                                }
                            }
                        }
                    }


                    guessOld = guess;
                } while (num != guess);
                Console.Clear();

                Console.WriteLine("yes {0} is correct answer you win", guess);
                Console.WriteLine("after {0} rounds! ", counter);
                Console.WriteLine("do you want to play again ? Y/N");
                yesOrNo = (Console.ReadLine().ToLower() == "y") ? true : false;

            } while (yesOrNo);

            Console.WriteLine("tnx for playing");








        }
    }
}