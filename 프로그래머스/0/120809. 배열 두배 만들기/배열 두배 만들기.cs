using System;

public class Solution {
    public int[] solution(int[] numbers) {
        int[] answer = new int[numbers.Length];
        
        for(int i = 0; i < numbers.Length; i++)
        {
            int shift = numbers[i] << 1;
            answer[i] = shift;
        }
        return answer;
    }
}