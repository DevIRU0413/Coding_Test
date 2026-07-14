using System;

public class Solution {
    public int[] solution(int[] numbers, int num1, int num2) {
        int length = num2 - num1;
        int[] answer = new int[length + 1];
        while(0 <= length)
        {
            answer[length] = numbers[num1 + length];
            length--;
        }
        return answer;
    }
}