using System;
namespace PalindromeExercise
{
    public class WordSmith
    {
      public bool IsAPalindrome(string word)
      {
            char[] charArray = word.ToLower().ToCharArray();
            Array.Reverse(charArray);
            return word.ToLower() == new string(charArray);
      }
    }
}
