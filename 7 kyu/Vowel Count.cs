//Vowel Count
//Return the number (count) of vowels in the given string.

//We will consider a, e, i, o, u as vowels for this Kata (but not y).

//The input string will only consist of lower case letters and/or spaces.

using System;
using System.Linq;

public static class Kata
{
  public static int GetVowelCount(string str) => 
      str.Count(c => "aeiou".Contains(Char.ToLower(c)));
        // Your code here
}
