using System.Text.RegularExpressions;

namespace Assignment2;

public class Palindromes
{
    
    public void PalindromeU()
    {
        Console.WriteLine("Enter a string:");
        string input = Console.ReadLine();

        // Use a HashSet to avoid duplicates and ignore case differences
        HashSet<string> foundPalindromes = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

        // Extract words using Regex
        foreach (Match match in Regex.Matches(input, @"\b[\w]+\b"))
        {
            string word = match.Value;
            if (IsPalindrome(word))
            {
                foundPalindromes.Add(word);
            }
        }

        Console.WriteLine("Palindromes found:");
        foreach (string palindrome in foundPalindromes)
        {
            Console.WriteLine(palindrome);
        }
    }


public static bool IsPalindrome(string word)
{
    int left = 0;
    int right = word.Length - 1;
    while (left < right)
    {
        if (char.ToLower(word[left]) != char.ToLower(word[right]))
        {
            return false;
        }
        left++;
        right--;
    }
    return true;
}

}
