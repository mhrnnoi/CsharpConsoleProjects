using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Collections;
using System.Text.RegularExpressions;

namespace New_folder__2_
{
    class Program
    {
        static void Main(string[] args)
        {
            var rnd = new Random();
            var g = rnd.Next(8, 15);
            Console.WriteLine(g);


            
            


        }

        public static string MostFrequent(string word)
        {
            var firstCount = word.Count(a=>a==word[0]);
            var counter = 0;
            char character = '0';
            for (int i = 1; i < word.Length; i++)
            {
                counter = word.Count(a=>a==word[i]);
                if (counter > firstCount)
                {
                    firstCount = counter;
                    character = word[i];
                }
                
            }
            if (character =='0')
            {
            return word[0].ToString();
                
            }
            return character.ToString();

        }
        
        public static int ProductDot(int[] nums1 , int[] nums2)
        {
            
            return nums1.Zip(nums2, (a, b) => a*b).Sum();
            
                
        }

        public static string UpperCase(string word)
        {
            var words = word.Split();
            var gs = words.Where(a => a == a.ToUpper());
            return string.Join(",", gs);
        }

        public static string SquareGthan20(int[] nums)
        {
            var gs = nums
                
                .Where(a=> Math.Pow(a,2) > 20)
                .Select(a => a.ToString()+"-"+(a*a).ToString());
        
            var gg = string.Join(",", gs);
            return gg;
        }
        public static string Selectwords(string[] words)
        {
            var gs = words.Where(a => a[0] =='a' && a[a.Length-1] =='m');
            return string.Join("", gs);
        }
        public static string  Top5Num(int[] nums)
        {
            Array.Sort(nums);
            Array.Reverse(nums);
            return string.Join(" ",nums.Take(5));
        }
        public static string Replacesubstring(string word)
        {
            word = word.Replace("ea","*");
            return word;
        }
        public static int Howmanydays(DateTime date, DateTime now)
        {
            var dif = now - date;
            return dif.Days;


        }

        public static bool AlmostLetters(string word)
        {
            if(word.Last() != '.')
                return false;
            word = word.Remove(word.Length-1,1);
            var words = word.Split();
            foreach (var item in words)
            {
                foreach (var item2 in item)
                {
                    if (char.IsLetter(item2) != true)
                        return false;
                }
            }
            return true;

        }
        public static string StartWithLower(string word)
        {
            var words = word.Split();

            for (int i = 0; i < words.Length; i++)
            {
                if (char.IsLower(words[i][0]))
                {
                    words[i] = words[i].Remove(0, 1);
                }
            }
            return string.Join(" ", words);
        }

        public static string IsUpperOrLower(string word)
        {
            var words = word.Split();
            foreach (var item in words)
            {
                item.ToLower();
            }
            for (int i = 0; i < words.Length; i += 2)
            {
                words[i] = words[i].ToUpper();
            }
            return string.Join(" ", words);
        }

        public static double PosOrNeg(double num)
        {
            if (num < 0)
                return Math.Pow(num, 2);
            return Math.Sqrt(num);

        }

        public static bool IsPalindrome(string word)
        {
            string word2 = "";
            for (int i = word.Length - 1; i >= 0; i--)
            {
                word2 += word[i];
            }
            return word == word2 ? true : false;

        }
        public static int Fibonachi(int num)
        {
            int add1 = 1;
            int add2 = 0;
            int adadBadi = 1;

            for (int i = 0; i < num; i++)
            {

                adadBadi = add1 + add2;
                add1 = add2;
                add2 = adadBadi;


            }
            return adadBadi;
        }
        public static int Factoriel(int number)
        {
            int sum = 1;
            for (int i = 1; i <= number; i++)
            {
                sum *= i;
            }
            return sum;
        }
        public static int MultiPLiction(int number)
        {

            var num = Convert.ToString(number);
            var sum = 1;
            for (int i = 0; i < num.Length; i++)
            {
                sum *= Convert.ToInt32((num[i].ToString()));
            }
            return sum;
        }

        public static string CompressString(string word)
        {
            string Komaki = " ";
            int total = 0;
            for (int i = 0; i < word.Length; i++)
            {

                if (Komaki[Komaki.Length - 1] == word[i])
                {
                    total++;
                }
                else
                {
                    if (total > 0)
                    {
                        Komaki += total;
                        Komaki += word[i];
                        total = 1;
                    }
                    else
                    {
                        Komaki += word[i];
                        total++;
                    }
                }

            }
            Komaki += total;
            Komaki = Komaki.Remove(0, 1);

            return Komaki;
        }
        public static int HowManyOccurence(string word, string subWord)
        {
            int total = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (word.IndexOf(subWord) > -1)
                {
                    total++;
                    word = word.Remove(word.IndexOf(subWord));
                }
            }
            return total;
        }

        public static string MixOfTwoString(string word1, string word2)
        {
            string word3 = "";

            if (word1.Length >= word2.Length)
            {
                for (int i = 0; i < word1.Length; i++)
                {
                    word3 += word1[i];

                }
                int m = 1;
                for (int j = 0; j < word2.Length; j++)
                {
                    word3 = word3.Insert(m, word2[j].ToString());
                    m += 2;
                }
            }
            else
            {
                for (int i = 0; i < word2.Length; i++)
                {
                    word3 += word2[i];

                }
                int m = 0;
                for (int j = 0; j < word1.Length; j++)
                {
                    word3 = word3.Insert(m, word1[j].ToString());
                    m += 2;
                }
            }


            return word3;
        }

        public static string RevertWordOrder(string word)
        {
            string word2 = "";
            string word3;

            string[] words;
            if (word[word.Length - 1] == '.')
            {
                word3 = word.Substring(0, word.Length - 1);
                words = word3.Split(" ");

                for (int i = words.Length - 1; i >= 0; i--)
                {
                    word2 += words[i];
                    if (i != 0)
                    {
                        word2 += " ";
                    }

                }
                word2 += '.';
            }
            else
            {
                words = word.Split(" ");

                for (int i = words.Length - 1; i >= 0; i--)
                {
                    word2 += words[i];
                    if (i != 0)
                    {
                        word2 += " ";
                    }

                }
            }
            return word2;


        }

        public static string MakeOddUpper(string word)
        {
            word = word.ToLower();
            var word2 = new StringBuilder(word);
            for (int i = 0; i < word2.Length; i += 2)
            {
                word2[i] = char.ToUpper(word2[i]);
            }
            return word2.ToString();
        }
        public static string Reverse(string word)
        {
            var word2 = "";
            for (int i = word.Length - 1; i >= 0; i--)
            {
                word2 += word[word[i]];
            }
            return word2;
        }
        public static int SumDigits(string word)
        {
            int sum = 0;
            foreach (var item in word)
            {
                if (char.IsNumber(item))
                {
                    sum += Convert.ToInt32(item.ToString());
                }
            }
            return sum;
        }

        public static bool CheckBracket(string sequance)
        {
            int opening = 0;
            int closing = 0;

            for (int i = 0; i < sequance.Length; i++)
            {
                if (sequance[i] == ')')
                    closing++;
                else if (sequance[i] == '(')
                    opening++;
            }
            return (opening == closing) ? true : false;
        }
        public static string AddSeparator(string word, string sep)
        {
            return string.Join(sep, word.AsEnumerable());
        }
        public static int DigitalRoot(int number)
        {
            int sum;

            while (number.ToString().Length > 1)
            {
                sum = 0;
                for (int j = 0; j < number.ToString().Length; j++)
                {
                    sum += int.Parse(number.ToString()[j].ToString());
                }
                number = sum;
            }
            return number;
        }
        public static string ReplaceTwoWord(string word, char sep)
        {
            string word2 = "";
            var g = word.Split(sep);
            word2 += g[1];
            word2 += sep;
            word2 += g[0];
            return word2;


        }
        public static bool LetterBalance(string word)
        {
            char left = word[0];
            char right = word[word.Length - 1];
            return left == right ? true : false;

        }
        public static void DrawTriangle()
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 0; j < 10 - i; j++)
                {
                    Console.Write(" ");
                }
                for (int m = 0; m < i; m++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        public static int DigitSum(int num)
        {
            var str = Convert.ToString(num); ;
            var sum = 0;
            for (int i = 0; i < str.Length; i++)
            {
                sum += Convert.ToInt32((str[i].ToString()));
            }
            return sum;
        }


        public static int BitToINt(string num)
        {
            return Convert.ToInt32(num, 2);

        }


        public static void DrawHourGlass()
        {
            for (int i = 0; i < 11; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
            for (int i = 0; i < 1; i++)
            {
                Console.Write(" ");
            }
            for (int i = 0; i < 9; i++)
            {
                Console.Write("*");
            }
            for (int i = 0; i < 1; i++)
            {
                Console.Write(" ");
            }
            Console.WriteLine();
            for (int i = 0; i < 2; i++)
            {
                Console.Write(" ");
            }
            for (int i = 0; i < 7; i++)
            {
                Console.Write("*");

            }
            for (int i = 0; i < 2; i++)
            {
                Console.Write(" ");
            }
            Console.WriteLine();
            for (int i = 0; i < 3; i++)
            {
                Console.Write(" ");
            }
            for (int i = 0; i < 5; i++)
            {
                Console.Write("*");
            }
            for (int i = 0; i < 3; i++)
            {
                Console.Write(" ");
            }
            Console.WriteLine();
            for (int i = 0; i < 4; i++)
            {
                Console.Write(" ");
            }
            for (int i = 0; i < 3; i++)
            {
                Console.Write("*");

            }
            for (int i = 0; i < 4; i++)
            {
                Console.Write(" ");
            }
            Console.WriteLine();
            for (int i = 0; i < 5; i++)
            {
                Console.Write(" ");
            }
            for (int i = 0; i < 1; i++)
            {
                Console.Write("*");

            }
            for (int i = 0; i < 5; i++)
            {
                Console.Write(" ");
            }
            Console.WriteLine();

            for (int i = 0; i < 4; i++)
            {
                Console.Write(" ");
            }
            for (int i = 0; i < 3; i++)
            {
                Console.Write("*");

            }
            for (int i = 0; i < 4; i++)
            {
                Console.Write(" ");
            }

            Console.WriteLine();
            for (int i = 0; i < 3; i++)
            {
                Console.Write(" ");
            }
            for (int i = 0; i < 5; i++)
            {
                Console.Write("*");
            }
            for (int i = 0; i < 3; i++)
            {
                Console.Write(" ");
            }

            Console.WriteLine();
            for (int i = 0; i < 2; i++)
            {
                Console.Write(" ");
            }
            for (int i = 0; i < 7; i++)
            {
                Console.Write("*");
            }
            for (int i = 0; i < 2; i++)
            {
                Console.Write(" ");
            }
            Console.WriteLine();
            for (int i = 0; i < 1; i++)
            {
                Console.Write(" ");
            }
            for (int i = 0; i < 9; i++)
            {
                Console.Write("*");
            }
            for (int i = 0; i < 1; i++)
            {
                Console.Write(" ");
            }
            Console.WriteLine();
            for (int i = 0; i < 11; i++)
            {
                Console.Write("*");
            }

        }
        public static int LongestStrictlyIncreasing(int[] nums)
        {
            int counter = 0;
            int biggest = 0;

            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (counter > biggest)
                {
                    biggest = counter;
                }
                counter = 0;

                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[j] - nums[i] == 1)
                    {
                        counter++;
                        i++;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            if (counter > biggest)
            {
                biggest = counter;
            }
            return biggest;
        }

        public static int Two7NextEachOther(int[] nums)
        {
            int counter = 0;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] == 7 && nums[i + 1] == 7)
                    counter++;
            }
            return counter;
        }


        public static int[] GetNums()
        {
            string[] numbers;
            int i = 0;
            string nums = "";
            string input;
            do
            {
                input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input))
                {
                    break;
                }

                nums += input;

                nums += " ";


            } while (!string.IsNullOrWhiteSpace(input));

            nums = nums.Trim();
            if (nums.Length > 0)
            {
                numbers = nums.Split(" ");
                int[] numbers2 = new int[numbers.Length];

                foreach (var item in numbers)
                {
                    numbers2[i] = Convert.ToInt32(item);
                }
                return numbers2;

            }
            return new int[] { 0 };


        }
        public static int SmallestNum(int[] nums)
        {
            Array.Sort(nums);
            return nums[0];
        }

        public static int BigestNum(int[] nums)
        {
            Array.Sort(nums);
            return nums[nums.Length - 1];
        }

        public static double Fractions(int num)
        {
            double sum = 0;
            for (double i = 1; i <= num; i++)
            {
                sum += (1 / i) * (1 / i);
            }

            return sum;
        }
        public static string MultiPLictionTable()
        {
            string table = "";
            for (int i = 1; i < 11; i++)
            {
                for (int j = 1; j < 11; j++)
                {
                    table += (i * j);
                    table += (" ");
                }
                table += "\n";
            }
            return table;
        }


        public static bool IsLeapYear(int year)
        {
            if (year % 4 == 0)
            {
                if (year % 100 == 0)
                    return (year % 400 == 0) ? true : false;
                return true;
            }
            return false;


        }

        public static int IsDivisibleBy2Or3(int a, int b)
        {
            if ((a % 3 == 0 || a % 2 == 0) && (b % 3 == 0 || b % 2 == 0))
                return a * b;
            return a + b;
        }

        public static bool IsSortedAscending(int[] arr)
        {
            var arr2 = new int[arr.Length];
            arr.CopyTo(arr2, 0);
            Array.Sort(arr);

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != arr2[i])
                    return false;

            }

            return true;
        }

        public static bool IsOnlyUpper2(string word)
        {
            return word.All<char>(c => char.IsUpper(c));
        }

        public static bool IsOnlyUpper(string word)
        {
            foreach (var item in word)
            {
                if (char.IsUpper(item) == false)
                    return false;
            }
            return true;
        }

        public static int Absoulute(int num)
        {
            return Math.Abs(num);
        }

        public static string SwapNum(int a, int b)
        {
            var c = a;
            a = b;
            b = c;
            return string.Format($"before a is : {b}, b is {a} ; \nAfter a is {a} , b is {b}");
        }

        public static bool IsSame(int num, int num2)
        {
            return num == num2;
        }

        public static string CToF(double num)
        {
            if (num < -271.15)
                return ("absolute zero");
            return (num * 9 / 5 + 32).ToString();

        }


    }
}
