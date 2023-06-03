using System.Collections.Generic;

namespace dattime
{


    public class summorizer
    {
        public static string summorizermethod(string klme, int maxLenght)
        {
            if (klme.Length < maxLenght)
            {
                return (klme);
            }


            var splittedWords = (klme.Trim()).Split(" ");
            var counter = 0;
            var lissi = new List<string>();
            foreach (var item in splittedWords)
            {
                foreach (var item2 in item)
                {
                    counter++;
                }
                counter++;
                if (counter >= maxLenght)
                {
                    break;
                }
                lissi.Add(item);

            }

            return string.Join(' ', lissi) + "...";

        }
    }
}
            