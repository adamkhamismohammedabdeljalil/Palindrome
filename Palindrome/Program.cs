namespace Palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please insert a word or text");
            PalindromeChecker reversed = new PalindromeChecker();
            string word = Console.ReadLine();
            string reversedWord = reversed.ReverseMethod(word);
            
            if (word == reversedWord)
            {
                Console.WriteLine($"{word} is a palindrome!");
            }
            else
            {
                Console.WriteLine($"{word} is not a palindrome");
            }
        }
    }
}