using System;

public class Solution {
    public int solution(int[] numbers) {
        int answer = 0;
        
        Array.Sort(numbers);
        int lastIdx = numbers.Length - 1;
        int first = numbers[0] * numbers[1];
        int last =  numbers[lastIdx - 1] * numbers[lastIdx];
        
        answer = (first > last) ? first : last;
        return answer;
    }
}