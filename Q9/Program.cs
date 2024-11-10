using System.Runtime.CompilerServices;

namespace Q9
{
    static class Program // a static class to hold the extention methods 
    {
        static void Main(string[] args)
        {
            int result = 23.By2Less1();
            Console.WriteLine(result);

            string text = "this is a test sentance";

            Console.WriteLine("The number of words in \"{0}\" is {1}", text, text.WordCount());

            Console.WriteLine();

        } 
        // defining a static method
        public static int By2Less1(this int num)
        {
            return num * 2 - 1;
        }
        public static int WordCount(this string text) // "this" keyword specific to the extention method indicates this extention method will be applied to strings 
        {
            string[] words = text.Split(' ');
            return words.Length;    
        }

    }
}