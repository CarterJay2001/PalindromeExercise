using System;
namespace PalindromeExercise
{
    public class WordSmith
    {
      public bool IsAPalindrome(string word)
      {
            char[] charArray = word.ToCharArray();
            Array.Reverse(charArray);
            return word == new string(charArray);
      }
    }
}
