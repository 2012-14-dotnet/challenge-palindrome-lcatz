using System;
using Palindrome.Domain;

namespace Palindrome.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            UserView();
        }


        static void UserView()
        {
            //while(play = 1)
            Console.WriteLine("Please enter a word or phrase.");
            string UserEntry = Console.ReadLine();
            PalindromeClean Entry = new PalindromeClean(UserEntry);
            bool Result = Entry.IsStringPalindrome();
            if (Result)
            {
                Console.WriteLine("Wow!  It's a palindrome alright.");
            }
            else
            {
                Console.WriteLine("Not a palindrome.");
            }

        }
    }
}
