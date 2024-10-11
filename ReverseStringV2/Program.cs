namespace ConsoleApp4;

public class Program
{
    static void Main(string[] args)
    {


        Console.WriteLine("Hello, This program will reserve a string.");
        Console.WriteLine(("Please enter a word:"));

        //convert to lower case to check for palindrome
        string word = (Console.ReadLine().ToLower());

        Console.WriteLine($"You have entered: {word}");

        // convert string to character
         char[] chars = word.ToCharArray();

        //lenght of string
        int lenght = chars.Length;

        Console.WriteLine($"String length is: {lenght}");
        Console.WriteLine($"We will now reverse the word {word}.");


        //Array.reverse option
        //Array.Reverse(chars);
        //Console.WriteLine(new string(chars));

        // lenght-1 index count backwards
        //i-- (comes from end to index)

        for (int i = lenght - 1; i >= 0; i--)
        {
            Console.WriteLine($" The reverse string is: {chars[i]}");
        }

        //check for palindrome

        int left = 0;
        int right = word.Length - 1;
        bool isPalindrome = true;
        while (left < right)
        {
            if (word[left] != word[right])
            {
                isPalindrome = false;
                break;
            }
            //compare left string(left to right)  and right string (right to left)
            left++;
            right--;
        }

        if (isPalindrome)
        {
            Console.WriteLine("The string is palindrome");
        }
        else
        {
            Console.WriteLine(("The string is not a palindrome"));
        }
    }
}