using System;

public class Solution {
    public string solution(int age) {
        int digitCount = (int)Math.Log10(age) + 1;
        char[] answer = new char[digitCount];
        for(int i = digitCount; i > 0; i--){
            int c = (int)Math.Pow(10, i - 1);
            int digit = age / c;
            age %= c;            
            answer[digitCount - i] = (char)('a' + digit);
        }
        return new string(answer);
    }
}