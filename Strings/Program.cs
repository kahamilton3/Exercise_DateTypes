using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstSentence = "Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it, 'and what is the use of a book,' thought Alice 'without pictures or conversation?'";
            Console.WriteLine("Enter a search term: ");
            string searchTerm = Console.ReadLine();
            Console.WriteLine("The index of the search term is " + firstSentence.ToLower().IndexOf(searchTerm.ToLower()) + ", and the length of the search term is " + searchTerm.Length);
            bool message = Class1.TermSearch(firstSentence, searchTerm);
            Console.WriteLine(message);
            Console.ReadLine();
            string newSentence = firstSentence.Remove(firstSentence.ToLower().IndexOf(searchTerm.ToLower()), searchTerm.Length + 1);
            Console.WriteLine(newSentence);
        }
    }
}