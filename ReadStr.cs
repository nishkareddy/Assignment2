namespace Assignment2;

public class ReadStr
{
    public void ReadStringC()
    {
        Console.WriteLine("Enter a string:");
        string str = Console.ReadLine();
        char[] rev = str.ToCharArray();
        Array.Reverse(rev);
        string reversedString = new string(rev);
        Console.WriteLine("Reversed string: " + reversedString);
        

    }
        
    }
