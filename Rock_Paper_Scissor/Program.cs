using System;

namespace Rock_Paper_Scissor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Welcome To This Mini Game Hope You Enjoy It.");

            string input, comTurn, result, onOff;

            int playerWin = 0;
            int comWin = 0;
            int draw = 0;

            do
            {
                Console.WriteLine("Plz Enter Rock, Paper, Scissor To Play");
                input = Console.ReadLine().ToLower();

                while (InputValid(input) == false)
                {
                    Console.WriteLine("Plz Enter just Rock or Paper or Scissor To Play!! not anything else.");
                    input = Console.ReadLine().ToLower();
                }

                comTurn = ComTurn();

                result = GameAnalyse(comTurn, input);

                GameResult(result, ref playerWin, ref comWin, ref draw);

                Console.WriteLine($"computer: {comTurn}");
                Console.WriteLine($"You: {input}");
                Console.WriteLine(result);

                Console.WriteLine("Would you like to play again? Y/N ");

                onOff = Console.ReadLine().ToLower();

                while (GameOnOffValidation(onOff) != true)
                {
                    Console.WriteLine("plz enter just  Y or N ");
                    onOff = Console.ReadLine().ToLower();
                }
                Console.Clear();


            } while (GameOnOff(onOff));

            Console.WriteLine("tnx for playing this game bye bye");
            Console.WriteLine($"number of player wins {playerWin} Times");
            Console.WriteLine($"number of com wins {comWin} Times");
            Console.WriteLine($"number of draws {draw} Times");

            Console.WriteLine(GameWinner(playerWin, comWin));





        }

        public static void GameResult(string result, ref int playerWin, ref int comWin, ref int draw)
        {
            switch (result)
            {
                case "You Win!!":
                    playerWin++;
                    break;

                case "You Lose!!":
                    comWin++;
                    break;

                default:
                    draw++;
                    break;
            }
        }

        public static bool GameOnOff(string input)
        {
            return (input == "y") ? true : false;
        }

        public static bool GameOnOffValidation(string input)
        {
            if (input != "y" && input != "n")
                return false;

            return true;
        }

        public static string ComTurn()
        {
            string[] com = { "rock", "paper", "scissor" };

            return com[new Random().Next(com.Length)];
        }
        public static bool InputValid(string input)
        {
            string[] validInputs = { "rock", "paper", "scissor" };

            if (Array.IndexOf(validInputs, input) == -1)
                return false;

            return true;


        }


        public static string GameWinner(int userWins, int comWins)
        {
            if (userWins > comWins)
                return "well done friend! you're good player";

            else if (comWins > userWins)
            {
                return "its okay practice more";
            }

            return "such a wow Draww!!";
        }
        public static string GameAnalyse(string comTurn, string userTurn)
        {
            // default is scissor

            switch (comTurn)
            {
                case "rock":

                    switch (userTurn)
                    {
                        case "paper":
                            return "You Win!!";

                        case "rock":
                            return "Draw!!";

                        default:
                            return "You Lose!!";
                    }

                case "paper":

                    switch (userTurn)
                    {
                        case "paper":
                            return "Draw!!";

                        case "rock":
                            return "You Lose!!";

                        default:
                            return "You Win!!";
                    }

                default:

                    switch (userTurn)
                    {
                        case "paper":
                            return "You Lose!!";

                        case "rock":
                            return "You Win!!";

                        default:
                            return "Draw!!";
                    }
            }
        }



    }
}
