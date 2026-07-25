using System;

public class Solution
{
    public int solution(int[] array, int n)
    {
        int count = 0;
        foreach (int value in array)
            if (value == n)
                count++;
        return count;
    }
}