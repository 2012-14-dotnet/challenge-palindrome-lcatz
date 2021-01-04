namespace Palindrome.Domain
{
    public class PalindromeClean
    {
        public string CleanEntry { get; set; }

        public PalindromeClean(string UserEntry)
        {
            CleanEntry = UserEntry.Replace(" ", "");
        }

        public bool IsStringPalindrome()
        {
            string ReverseString;
            for (int i = CleanEntry.Length -1; i >=0; i--)
            {
                ReverseString += CleanEntry[i].ToString(); 
            }
            if (ReverseString == CleanEntry)
            {
                return true;
            }
            else {return false;}
        }
    }
}