using System;

public class Solution {
    public int solution(int[] numbers) {
        int answer = 0;
        
        Array.Sort(numbers);
        int length = numbers.Length;
        int first = numbers[0] * numbers[1];
        int last =  numbers[length - 2] * numbers[length - 1];
        
        answer = (first > last) ? first : last;
        return answer;
    }
}