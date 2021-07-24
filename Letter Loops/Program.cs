using System;

namespace Letter_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please type some letters and press enter.");
            var letterString = Console.ReadLine();
            var letters = letterString.ToLower();
            var counter = 1;
            string newString = "";
            foreach (var letter in letters)
            {
                for (var i = 0; i < counter; i++)
                {
                    newString += letter;
                }
                newString += "-";
                counter++;
            }

            char[] multiplyAndCapitalize = newString.ToCharArray();
            // Handle the first letter in the string.
            if (multiplyAndCapitalize.Length >= 1)
            {
                if (char.IsLower(multiplyAndCapitalize[0]))
                {
                   multiplyAndCapitalize[0] = char.ToUpper(multiplyAndCapitalize[0]);
                }
            }
            // Scan through the letters, checking for spaces.
            // ... Uppercase the lowercase letters following spaces.
            for (int i = 1; i < multiplyAndCapitalize.Length; i++)
            {
              if (multiplyAndCapitalize[i - 1] == '-')
              {
                if (char.IsLower(multiplyAndCapitalize[i]))
                {
                  multiplyAndCapitalize[i] = char.ToUpper(multiplyAndCapitalize[i]);
                }
              }
            }
            //return new string(array);
            Console.WriteLine(multiplyAndCapitalize);
            Console.WriteLine(newString);
        }
    }
}