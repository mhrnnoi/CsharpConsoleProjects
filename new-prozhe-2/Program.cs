using System;

namespace new_prozhe_2
{
    class Program
    {
        static void Main(string[] args)
        {
            const string firstName = "mehran ";
            string lastName = "noi";
            Console.WriteLine($"hello dear {firstName} {lastName}");
            float age = 21.7f;
            double dateOfBirth = 1379.10;
            char firstWord ='M';
            bool aliveOrDeath = true; 
            Console.WriteLine($"{firstName} {lastName} is {age} old his first character"+
            $" is {firstWord} \nand he is alive becuz he got {aliveOrDeath} status \n" +
            $"and his date of birth is {dateOfBirth}");
            lastName = "naser";

            string firsrname = "meeern" , name = "mern" , nickname = "mian" , esm = "mehran";
            Console.WriteLine($"{firsrname},{name},{esm},{nickname},");

            int a=50,b=50,c = 500;
            Console.WriteLine($"{a},{b},{c}");

            
        }
    }
}
