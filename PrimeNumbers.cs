namespace Assignment2;

public class PrimeNumbers
{
    public int[] FindPrimesInRange(int startNum, int endNum)
    {
        List<int> primesList = new List<int>();
        for (int num = startNum; num <= endNum; num++)
        {
            if (IsPrime(num))
            {
                primesList.Add(num);
            }
        }

        return primesList.ToArray();
    }
    private bool IsPrime(int number)
    {
        if (number <= 1) return false;
        if (number <= 3) return true;
        if (number % 2 == 0 || number % 3 == 0) return false;
        for (int i = 5; i * i <= number; i += 6)
        {
            if (number % i == 0 || number % (i + 2) == 0) return false;
        }
        return true;
    }
}