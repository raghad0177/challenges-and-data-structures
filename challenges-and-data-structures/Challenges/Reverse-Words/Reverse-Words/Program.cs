using System.Runtime.InteropServices;

namespace Reverse_Words
{
    public class Program
    {
        static void Main(string[] args)
        {
            string words = "csharp is programming language";
            string result =ReverseWords(words);
            Console.WriteLine(result);
          
        }

        public static string ReverseWords(string words)
        {
            string[] wordsArray = words.Split(" ");
            string[] result = new string[wordsArray.Length];
            int count = 0;
            for (int i = wordsArray.Length-1; i >=0 ; i--) { 
                  result[count++] = wordsArray[i];
            }
            string reversed=string.Join(" ", result);
            return reversed;
        }
    }
}
