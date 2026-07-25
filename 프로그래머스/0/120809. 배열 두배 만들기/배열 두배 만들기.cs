using System;

public class Solution {
    public int[] solution(int[] numbers) {
        for(int i = 0; i < numbers.Length; i++)
        {
            int shift = numbers[i] << 1;
            numbers[i] = shift;
        }
        return numbers;
    }
}