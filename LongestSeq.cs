namespace Assignment2;

public class LongestSeq
{
    public void LongestSequence()
    {
        int[][] inputArrays =
        {
            new int[] { 2, 1, 1, 2, 3, 3, 2, 2, 2, 1, 2, 2, 2 },
            new int[] { 1, 1, 1, 2, 3, 1, 3, 3, 1, 1, 1 },
            new int[] { 4, 4, 4, 4, 4, 4, 4, 4 },
            new int[] { 0, 1, 1, 5, 2, 2, 6, 3, 3, 1, 1 }
        };
        foreach (var array in inputArrays)
        {
            int bestStart = 0;
            int bestLength = 1;
            int currentStart = 0;
            int currentLength = 1;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] == array[i - 1])
                {
                    currentLength++;
                }
                else
                {
                    if (currentLength > bestLength)
                    {
                        bestLength = currentLength;
                        bestStart = currentStart;
                    }
                    currentStart = i;
                    currentLength = 1;
                }
            }
            if (currentLength > bestLength)
            {
                bestLength = currentLength;
                bestStart = currentStart;
            }

            Console.WriteLine($"Longest sequence in [{string.Join(", ", array)}]:");
            Console.WriteLine($"{string.Join(" ", Enumerable.Repeat(array[bestStart], bestLength))}\n");
        }
    }

}
