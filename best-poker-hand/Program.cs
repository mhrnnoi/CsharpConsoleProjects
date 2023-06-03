using System;
using System.Linq;
namespace best_poker_hand
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME ");


            var rnks = new int[] { 1, 3, 4, 9, 5 };
            var suits = new char[] { '♠', 'a', '♠', '♠', '♠' };
            Console.WriteLine(BestHand(rnks, suits));

        }





        public static string BestHand(int[] ranks, char[] suits)
        {
            if (IsRoyalFlush(ranks, suits))
                return "Royal Flush Wow ";

            else if (IsStraightFlush(ranks, suits))
                return "Straight flush ";

            else if (IsFourOfKind(ranks))
                return "Four of Kind";

            else if (IsFullHouse(ranks))
                return "Full House";

            else if (IsFlush(suits))
                return "Flush";

            else if (IsStraight(ranks))
                return "Straight";

            else if (IsThreeOfKind(ranks))
                return "Three of Kind";

            else if (IsTwoPair(ranks))
                return "Two Pair";

            else if (IsPair(ranks))
                return "Pair";
            else
                return "high card : " + HighCard(ranks);
        }

        public static bool IsRoyalFlush(int[] ranks, char[] suits)
        {
            int[] royal = { 1, 10, 11, 12, 13 };
            if (IsFlush(suits))
            {
                Array.Sort(ranks);
                for (int i = 0; i < royal.Length; i++)
                {
                    if (ranks[i] != royal[i])
                        return false;
                }
                return true;
            }
            return false;
        }

        public static bool IsFourOfKind(int[] ranks)
        {
            var sameRank = 1;

            bool x = false;

            for (int i = 0; i < ranks.Length - 1; i++)
            {
                sameRank = 1;
                for (int j = i; j < ranks.Length - 1; j++)
                {
                    if (ranks[i] == ranks[j + 1])
                        sameRank++;
                }
                x = (sameRank == 4) ? true : false;
                if (x)
                    return x;

            }
            return x;
        }

        public static bool IsFullHouse(int[] ranks)
        {
            if (IsThreeOfKind(ranks))
            {
                var num = IsThreeOfKindNums(ranks);

                var sameRank = 1;

                bool x = false;

                for (int i = 0; i < ranks.Length - 1; i++)
                {
                    sameRank = 1;
                    for (int j = i; j < ranks.Length - 1; j++)
                    {
                        if (ranks[i] == ranks[j + 1] && ranks[i] != num)
                            sameRank++;
                    }
                    x = (sameRank == 2) ? true : false;
                    if (x)
                        return x;

                }
                return x;
            }
            return false;
        }

        public static bool IsStraightFlush(int[] ranks, char[] suits)
        {
            if (IsFlush(suits))
            {
                if (IsStraight(ranks))
                {
                    return true;
                }
                return false;
            }
            return false;
        }

        public static bool IsTwoPair(int[] ranks)
        {

            var sameRank = 1;
            var pairs = 0;
            bool x = false;

            for (int i = 0; i < ranks.Length - 1; i++)
            {
                sameRank = 1;
                for (int j = i; j < ranks.Length - 1; j++)
                {
                    if (ranks[i] == ranks[j + 1])
                        sameRank++;
                }
                x = (sameRank == 2) ? true : false;
                if (x)
                    pairs++;


            }
            return (pairs == 2) ? true : false;
        }


        public static bool IsStraight(int[] ranks)
        {



            Array.Sort(ranks);

            for (int i = 0; i < ranks.Length - 1; i++)
            {
                if (ranks[i] != ranks[i + 1] - 1)
                    return false;
            }
            return true;
        }

        public static bool IsFlush(char[] suits)
        {
            var sameSuit = 1;
            for (int i = 0; i < suits.Length - 1; i++)
            {
                if (suits[i] == suits[i + 1])
                    sameSuit++;
            }


            if (sameSuit == 5)
                return true;
            return false;
        }

        public static int IsThreeOfKindNums(int[] ranks)
        {
            var sameRank = 1;

            bool x = false;

            for (int i = 0; i < ranks.Length - 1; i++)
            {
                sameRank = 1;
                for (int j = i; j < ranks.Length - 1; j++)
                {
                    if (ranks[i] == ranks[j + 1])
                        sameRank++;
                }
                x = (sameRank == 3) ? true : false;
                if (x)
                    return ranks[i];

            }
            return 0;
        }



        public static bool IsPair(int[] ranks)
        {

            var sameRank = 1;

            bool x = false;

            for (int i = 0; i < ranks.Length - 1; i++)
            {
                sameRank = 1;
                for (int j = i; j < ranks.Length - 1; j++)
                {
                    if (ranks[i] == ranks[j + 1])
                        sameRank++;
                }
                x = (sameRank == 2) ? true : false;
                if (x)
                    return x;

            }
            return x;
        }



        public static bool IsThreeOfKind(int[] ranks)
        {
            var sameRank = 1;

            bool x = false;

            for (int i = 0; i < ranks.Length - 1; i++)
            {
                sameRank = 1;
                for (int j = i; j < ranks.Length - 1; j++)
                {
                    if (ranks[i] == ranks[j + 1])
                        sameRank++;
                }
                x = (sameRank == 3) ? true : false;
                if (x)
                    return x;

            }
            return x;
        }


        public static string HighCard(int[] ranks)
        {

            if (ranks.Contains(1))

                //cuz 1 is highest card
                return 1.ToString();

            return ranks.Max().ToString();

        }


    }
}
