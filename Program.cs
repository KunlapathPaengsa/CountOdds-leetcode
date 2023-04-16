public class Solution
{
    public int CountOdds(int low, int high)
     => (low % 2 != 0 && high % 2 != 0) ||
        (low % 2 == 0 && high % 2 != 0) || 
        (low % 2 != 0 && high % 2 == 0)
     ? ((high - low) / 2) + 1 : (high - low) / 2;

    public int CountOdds1(int low, int high)
    {
        int count = 0;
        for (int i = low; i <= high; i++)
        {
            if (i % 2 != 0)
            {
                count++;
            }
        }
        return count;
    }

    public int CountOdds2(int low, int high)
    {
        return (high + 1) / 2 - (low) / 2;
    }
}