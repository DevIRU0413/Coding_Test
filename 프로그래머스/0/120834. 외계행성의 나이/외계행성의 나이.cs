using System;

public class Solution {
    public string solution(int age) {
        int digitCount = (int)Math.Log10(age) + 1;
        char[] answer = new char[digitCount];
        for(int i = digitCount - 1; i >= 0; i--)
        {
            answer[i] = (char)('a' + age % 10);
            age /= 10; 
        }
        return new string(answer);
    }
}