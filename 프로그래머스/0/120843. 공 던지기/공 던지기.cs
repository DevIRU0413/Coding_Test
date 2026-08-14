using System;

public class Solution {
    public int solution(int[] numbers, int k) {
        int answer = (2 * k - 1) % numbers.Length;
        if(answer == 0)
            answer = numbers.Length;
        answer -= 1;
        return numbers[answer];
    }
}